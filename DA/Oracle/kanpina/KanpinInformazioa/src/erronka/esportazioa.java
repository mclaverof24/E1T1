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
     * esportatzeko prozesu osoa kudeatzen du.
     * @param config Properties objektua, datu-basearen konexio-parametroak dituena.
     */
    public void esportatu(Properties config) {
        // Konexio-parametroak irakurri eta zuriuneak kendu (trim)
        String dbUrl = config.getProperty("db_url").trim();
        String dbUser = config.getProperty("db_user").trim();
        String dbPass = config.getProperty("db_pass").trim();
        
        // Esportazio-karpeta sortu, existitzen ez bada
        File dir = new File(ESPORTAZIOA_KARPETA);
        if (!dir.exists()) {
            dir.mkdir();
            System.out.println("Karpeta sortua: " + ESPORTAZIOA_KARPETA);
        }
        
        try (Connection conn = DriverManager.getConnection(dbUrl, dbUser, dbPass)) {
            
            // SQL kontsulta: KANPINAK taula HERRIAK eta PROBINTZIAK taulekin lotu
            String sql = "SELECT K.IZENA, H.IZENA AS UDALERRIA, P.IZENA AS LURRALDEA, K.KATEGORIA, K.EDUKIERA AS AHALMENA " +
                         "FROM KANPINAK K " +
                         "JOIN HERRIAK H ON K.HERRI_KODEA = H.KODEA " +
                         "JOIN PROBINTZIAK P ON K.PROBINTZIA_KODEA = P.KODEA " +
                         "ORDER BY K.IZENA";

            // Statement sortu, ResultSet-a atzera-aurrera mugitzeko modukoa izan dadin (bi esportazioetarako)
            try (Statement stmt = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY); 
                 ResultSet rs = stmt.executeQuery(sql)) {
                
                // 1. Datuak CSV fitxategira esportatu
                esportatuCSV(rs);
                
                // 2. ResultSet-a hasierara itzuli
                rs.beforeFirst(); 
                esportatuXML(rs);

            }
        } catch (Exception e) {
            System.err.println("Esportazioan errorea gertatu da: ");
            e.printStackTrace();
        }
    }
    
    /**
     * Kontsultaren emaitza-multzoa (ResultSet) CSV formatuan esportatzen du.
     * @param rs Datu-basearen emaitza-multzoa.
     */
    private void esportatuCSV(ResultSet rs) throws SQLException, IOException {
        String csvFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.csv";
        try (FileWriter writer = new FileWriter(csvFitx)) {
            
            // CSV goiburua idatzi
            writer.append("Izena;Udalerria;Lurraldea;Kategoria;Ahalmena\n");
            
            // Datu guztiak iteratu eta idatzi
            while (rs.next()) {
                writer.append(rs.getString("IZENA")).append(";");
                writer.append(rs.getString("UDALERRIA")).append(";");
                writer.append(rs.getString("LURRALDEA")).append(";");
                writer.append(rs.getString("KATEGORIA")).append(";");
                writer.append(String.valueOf(rs.getInt("AHALMENA"))).append("\n");
            }
            System.out.println("Datuak CSV fitxategira esportatu dira: " + csvFitx);
        }
    }

    /**
     * Kontsultaren emaitza-multzoa (ResultSet) XML formatuan esportatzen du.
     * Elementu bakoitzaren eraikuntza funtzio laguntzaile batean zentralizatu da irakurgarritasuna hobetzeko.
     * @param rs Datu-basearen emaitza-multzoa.
     */
    private void esportatuXML(ResultSet rs) throws SQLException, IOException {
        String xmlFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.xml";
        try (FileWriter writer = new FileWriter(xmlFitx)) {
            
            writer.append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
            writer.append("<kanpinak>\n");

            while (rs.next()) {
                writer.append(buildKanpinaXmlElement(rs));
            }

            writer.append("</kanpinak>");
            System.out.println("Datuak XML fitxategira esportatu dira: " + xmlFitx);
        }
    }
    
    /**
     * ResultSet-eko uneko lerrotik XML kanpin elementu osoa sortzen du.
     * @param rs Datu-basearen emaitza-multzoa.
     * @return Kanpinaren XML errepresentazioa String gisa.
     */
    private String buildKanpinaXmlElement(ResultSet rs) throws SQLException {
        StringBuilder sb = new StringBuilder();
        sb.append("\t<kanpina>\n");
        sb.append("\t\t<izena>").append(rs.getString("IZENA")).append("</izena>\n");
        sb.append("\t\t<udalerria>").append(rs.getString("UDALERRIA")).append("</udalerria>\n");
        sb.append("\t\t<lurraldea>").append(rs.getString("LURRALDEA")).append("</lurraldea>\n");
        sb.append("\t\t<kategoria>").append(rs.getString("KATEGORIA")).append("</kategoria>\n");
        sb.append("\t\t<ahalmena>").append(rs.getInt("AHALMENA")).append("</ahalmena>\n");
        
        sb.append("\t</kanpina>\n");
        return sb.toString();
    }
}