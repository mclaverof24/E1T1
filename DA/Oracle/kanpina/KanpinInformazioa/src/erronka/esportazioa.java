package erronka;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.sql.ResultSet;
import java.util.Properties;
import java.sql.*;

/**
 * Klase hau datu-baseko kanpin-datuak (KANPINAK) irakurtzeaz eta bi formatutan
 * (CSV eta XML) kanpoko fitxategietara esportatzeaz arduratzen da.
 */
public class esportazioa {
    
    // Esportatutako fitxategiak gordeko diren karpetaren izena.
    private static final String ESPORTAZIOA_KARPETA = "esportazioa";

    /**
     * Konexioa ezarri, DBko kontsulta exekutatu eta datuak CSV eta XML fitxategietara
     * esportatzeko prozesu osoa kudeatzen du, probintzia eta herri zehatz baterako datuak iragaziz.
     * @param config Properties objektua, datu-basearen konexio-parametroak dituena.
     * @param probintziaIzena Esportatu nahi den probintziaren izena.
     * @param herriaIzena Esportatu nahi den herriaren izena.
     */
    public void esportatu(Properties config, String herriaIzena) {
        // Konexio-parametroak irakurri
        String dbUrl = config.getProperty("db_url").trim();
        String dbUser = config.getProperty("db_user").trim();
        String dbPass = config.getProperty("db_pass").trim();
        
        // Esportazio-karpeta sortu
        File dir = new File(ESPORTAZIOA_KARPETA);
        if (!dir.exists()) {
            dir.mkdir();
            System.out.println("Karpeta sortua: " + ESPORTAZIOA_KARPETA);
        }
        
        try (Connection conn = DriverManager.getConnection(dbUrl, dbUser, dbPass)) {
            
            // SQL kontsulta PreparedStatement-erako: HERRIAK eta PROBINTZIAK iragazteko WHERE klausula erabiliz.
            String sql = "SELECT K.KODEA, K.IZENA, K.DESKRIBAPENA, K.KOKALEKUA, K.HELBIDEA, K.POSTAKODEA, " +
                         "H.IZENA AS HERRIA, P.IZENA AS PROBINTZIA, H.KODEA AS HERRI_KODEA, P.KODEA AS PROBINTZIA_KODEA, " +
                         "K.KATEGORIA, K.EDUKIERA AS EDUKIERA, K.TELEFONOA, K.EMAILA, K.WEBGUNEA, " +
                         "K.FRIENDLY_URL, K.PHYSICAL_URL, K.DATA_XML, K.METADATA_XML, K.ZIP_FILE " +
                         "FROM KANPINAK K " +
                         "JOIN HERRIAK H ON K.HERRI_KODEA = H.KODEA " +
                         "JOIN PROBINTZIAK P ON K.PROBINTZIA_KODEA = P.KODEA " +
                         "WHERE H.KODEA = ? " + // <-- Iragazkiak hemen aplikatuta
                         "ORDER BY K.IZENA";

            // PreparedStatement sortu (scrollable ResultSet-erako)
            try (PreparedStatement pstmt = conn.prepareStatement(sql, 
                 ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY)) {

                // Parametroak ezarri (DB injekzioa saihesteko)
                pstmt.setString(1, herriaIzena.trim());
                
                try (ResultSet rs = pstmt.executeQuery()) {
                    
                    // 1. Datuak CSV fitxategira esportatu
                    esportatuCSV(rs);
                    
                    // 2. ResultSet-a hasierara itzuli
                    rs.beforeFirst(); 
                    esportatuXML(rs);

                } // ResultSet itxi
            } // PreparedStatement itxi
        } catch (Exception e) {
            System.err.println("Esportazioan errorea gertatu da: ");
            e.printStackTrace();
        } // Konexioa itxi
    }
    
    /**
     * Kontsultaren emaitza-multzoa (ResultSet) CSV formatuan esportatzen du,
     * eskatutako zutabeekin eta TABULAZIOA (\t) bereizle gisa erabiliz.
     * @param rs Datu-basearen emaitza-multzoa.
     */
    private void esportatuCSV(ResultSet rs) throws SQLException, IOException {
        String csvFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.csv";
        try (FileWriter writer = new FileWriter(csvFitx)) {
            writer.append("Kodea\tIzena\tKokalekua\tHelbidea\tPostaKodea\tHerria\tProbintzia\tKategoria\tEdukiera\n");
            
            // Datu guztiak iteratu eta idatzi
            while (rs.next()) {
                writer.append(rs.getString("KODEA")).append("\t");
                writer.append(rs.getString("IZENA")).append("\t");
                writer.append(rs.getString("KOKALEKUA")).append("\t");
                writer.append(rs.getString("HELBIDEA")).append("\t");
                writer.append(rs.getString("POSTAKODEA")).append("\t"); 
                writer.append(rs.getString("HERRIA")).append("\t");
                writer.append(rs.getString("PROBINTZIA")).append("\t");
                writer.append(rs.getString("KATEGORIA")).append("\t");
                writer.append(String.valueOf(rs.getInt("EDUKIERA"))).append("\n");
            }
            System.out.println("Datuak CSV fitxategira esportatu dira: " + csvFitx);
        }
    }

    /**
     * Kontsultaren emaitza-multzoa (ResultSet) XML formatu egituratu berrian esportatzen du.
     * @param rs Datu-basearen emaitza-multzoa.
     */
    private void esportatuXML(ResultSet rs) throws SQLException, IOException {
        String xmlFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.xml";
        try (FileWriter writer = new FileWriter(xmlFitx)) {
            
            // XML goiburu berria (standalone="no" barne)
            writer.append("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n");
            writer.append("<kanpinak>\n");

            while (rs.next()) {
                // Kanpin elementu osoa eraiki eta idatzi
                writer.append(buildKanpinaXmlElement(rs));
            }

            writer.append("</kanpinak>");
            System.out.println("Datuak XML fitxategira esportatu dira: " + xmlFitx);
        }
    }
    
    /**
     * ResultSet-eko uneko lerrotik XML kanpin elementu osoa sortzen du,
     * eskatutako egitura habiaratuarekin.
     */
    private String buildKanpinaXmlElement(ResultSet rs) throws SQLException {
        StringBuilder sb = new StringBuilder();
        sb.append("\t<kanpina id=\"").append(rs.getString("KODEA")).append("\">\n");
        sb.append("\t\t<izena>").append(rs.getString("IZENA")).append("</izena>\n");
        sb.append("\t\t<deskribapena>").append(rs.getString("DESKRIBAPENA")).append("</deskribapena>\n");
        sb.append("\t\t<kategoria>").append(rs.getString("KATEGORIA")).append("</kategoria>\n");
        sb.append("\t\t<edukiera>").append(rs.getInt("EDUKIERA")).append("</edukiera>\n");
        sb.append("\t\t<kokalekua>").append(rs.getString("KOKALEKUA")).append("</kokalekua>\n");
        sb.append("\t\t<helbidea>\n");
        sb.append("\t\t\t<kalea>").append(rs.getString("HELBIDEA")).append("</kalea>\n");
        sb.append("\t\t\t<postaKodea>").append(rs.getString("POSTAKODEA")).append("</postaKodea>\n");
        sb.append("\t\t\t<herria id=\"").append(rs.getInt("HERRI_KODEA")).append("\">").append(rs.getString("HERRIA")).append("</herria>\n");
        sb.append("\t\t\t<probintzia id=\"").append(rs.getInt("PROBINTZIA_KODEA")).append("\">").append(rs.getString("PROBINTZIA")).append("</probintzia>\n");
        sb.append("\t\t</helbidea>\n");
        sb.append("\t\t<telefonoa>").append(rs.getString("TELEFONOA")).append("</telefonoa>\n");
        sb.append("\t\t<emaila>").append(rs.getString("EMAILA")).append("</emaila>\n");
        sb.append("\t\t<webgunea>").append(rs.getString("WEBGUNEA")).append("</webgunea>\n");
        sb.append("\t\t<estekak>\n");
        sb.append("\t\t\t<friendly>").append(rs.getString("FRIENDLY_URL")).append("</friendly>\n");
        sb.append("\t\t\t<physical>").append(rs.getString("PHYSICAL_URL")).append("</physical>\n");
        sb.append("\t\t</estekak>\n");
        sb.append("\t\t<fitxategiak>\n");
        sb.append("\t\t\t<dataXML>").append(rs.getString("DATA_XML")).append("</dataXML>\n");
        sb.append("\t\t\t<metadataXML>").append(rs.getString("METADATA_XML")).append("</metadataXML>\n");
        sb.append("\t\t\t<zipFile>").append(rs.getString("ZIP_FILE")).append("</zipFile>\n");
        sb.append("\t\t</fitxategiak>\n");
        
        sb.append("\t</kanpina>\n");
        return sb.toString();
    }
}