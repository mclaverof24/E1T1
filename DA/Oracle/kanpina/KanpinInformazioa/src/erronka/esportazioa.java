package erronka;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.sql.ResultSet;
import java.util.Properties;
import java.sql.*;

public class esportazioa {

    private static final String ESPORTAZIOA_KARPETA = "esportazioa";

    public void esportatu(Properties config) {
        String dbUrl = config.getProperty("db_url").trim();
        String dbUser = config.getProperty("db_user").trim();
        String dbPass = config.getProperty("db_pass").trim();
        
        File dir = new File(ESPORTAZIOA_KARPETA);
        if (!dir.exists()) {
            dir.mkdir();
            System.out.println("Karpeta sortua: " + ESPORTAZIOA_KARPETA);
        }
        
        try (Connection conn = DriverManager.getConnection(dbUrl, dbUser, dbPass)) {
            
            String sql = "SELECT K.IZENA, H.IZENA AS UDALERRIA, P.IZENA AS LURRALDEA, K.KATEGORIA, K.EDUKIERA AS AHALMENA " +
                         "FROM KANPINAK K " +
                         "JOIN HERRIAK H ON K.HERRI_KODEA = H.KODEA " +
                         "JOIN PROBINTZIAK P ON K.PROBINTZIA_KODEA = P.KODEA " +
                         "ORDER BY K.IZENA";
            try (Statement stmt = conn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY); 
                 ResultSet rs = stmt.executeQuery(sql)) {
                
                esportatuCSV(rs);
                rs.beforeFirst(); 
                esportatuXML(rs);

            }
        } catch (Exception e) {
            System.err.println("Esportazioan errorea gertatu da: ");
            e.printStackTrace();
        }
    }
    
    private void esportatuCSV(ResultSet rs) throws SQLException, IOException {
        String csvFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.csv";
        try (FileWriter writer = new FileWriter(csvFitx)) {
            
            writer.append("Izena;Udalerria;Lurraldea;Kategoria;Ahalmena\n");
            
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

    private void esportatuXML(ResultSet rs) throws SQLException, IOException {
        String xmlFitx = ESPORTAZIOA_KARPETA + File.separator + "kanpinak_export.xml";
        try (FileWriter writer = new FileWriter(xmlFitx)) {
            writer.append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");
            writer.append("<kanpinak>\n");

            while (rs.next()) {
                writer.append("\t<kanpina>\n");
                writer.append("\t\t<izena>").append(rs.getString("IZENA")).append("</izena>\n");
                writer.append("\t\t<udalerria>").append(rs.getString("UDALERRIA")).append("</udalerria>\n");
                writer.append("\t\t<lurraldea>").append(rs.getString("LURRALDEA")).append("</lurraldea>\n");
                writer.append("\t\t<kategoria>").append(rs.getString("KATEGORIA")).append("</kategoria>\n");
                writer.append("\t\t<ahalmena>").append(String.valueOf(rs.getInt("AHALMENA"))).append("</ahalmena>\n");
                writer.append("\t</kanpina>\n");
            }
            writer.append("</kanpinak>");
            System.out.println("Datuak XML fitxategira esportatu dira: " + xmlFitx);
        }
    }
}