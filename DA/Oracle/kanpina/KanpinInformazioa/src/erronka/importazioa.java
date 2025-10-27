package erronka;

import java.sql.*;
import javax.xml.parsers.*;
import org.w3c.dom.*;
import java.io.File;
import java.util.Properties;
import java.util.HashMap;
import java.util.Map;

public class importazioa {
    private String getElementValue(Element parent, String tagName) {
        NodeList nl = parent.getElementsByTagName(tagName);
        if (nl != null && nl.getLength() > 0) {
            Element el = (Element) nl.item(0);
            if (el != null && el.hasChildNodes()) {
                return el.getFirstChild().getNodeValue().trim();
            }
        }
        return null;
    }
    
    private String getElementValue(Element parent, String tagName, String defaultValue) {
         String value = getElementValue(parent, tagName);
         return value != null ? value : defaultValue;
    }
    private void truncateTables(Connection conn) {
        try (Statement stmt = conn.createStatement()) {
            stmt.executeUpdate("TRUNCATE TABLE KANPIN_ETIKETAK");
            stmt.executeUpdate("TRUNCATE TABLE KANPINAK");
            stmt.executeUpdate("TRUNCATE TABLE ETIKETAK");
            stmt.executeUpdate("TRUNCATE TABLE HERRIAK");
            stmt.executeUpdate("TRUNCATE TABLE PROBINTZIAK");
            
            System.out.println("Taulak garbitu dira.");
        } catch (SQLException e) {
            System.err.println("Ezin izan da taula batzuk garbitu. Egiaztatu konektatuta zaudela: " + e.getMessage());
        }
    }
    
    public void inportatu(Properties config) {
        String xmlFitx = config.getProperty("xml_fitxategia").trim();
        String dbUrl = config.getProperty("db_url").trim();
        String dbUser = config.getProperty("db_user").trim();
        String dbPass = config.getProperty("db_pass").trim();

        Connection conn = null;

        try {
            conn = DriverManager.getConnection(dbUrl, dbUser, dbPass);
            System.out.println("DB konexioa arrakastatsua.");
            truncateTables(conn);
            
            File file = new File(xmlFitx);
            DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
            DocumentBuilder db = dbf.newDocumentBuilder();
            Document doc = db.parse(file);
            doc.getDocumentElement().normalize();

            NodeList rowList = doc.getElementsByTagName("row");
            
            for (int i = 0; i < rowList.getLength(); i++) {
                Node rowNode = rowList.item(i);
                if (rowNode.getNodeType() == Node.ELEMENT_NODE) {
                    Element e = (Element) rowNode;

                    String kodea = getElementValue(e, "signatura");
                    String izena = getElementValue(e, "documentName");
                    String deskribapena = getElementValue(e, "documentDescription");
                    String kokalekua = getElementValue(e, "latitudelongitude");
                    
                    String telefonoa = getElementValue(e, "phone");
                    if (telefonoa != null) {
                        telefonoa = telefonoa.replaceAll("[\\s\\-\\(\\)\\+]", ""); 
                    }
                    
                    String helbidea = getElementValue(e, "address");
                    String emaila = getElementValue(e, "tourismEmail");
                    String webgunea = getElementValue(e, "web");
                    String kategoria = getElementValue(e, "category");
                    int edukiera = Integer.parseInt(getElementValue(e, "capacity", "0"));
                    String postaKodea = getElementValue(e, "postalCode");
                    
                    String probintziaIzena = getElementValue(e, "territory");
                    String probintziaKodeaStr = getElementValue(e, "territorycode");
                    int probintziaKodea = probintziaKodeaStr != null ? Integer.parseInt(probintziaKodeaStr) : 0;
                    
                    String herriaIzena = getElementValue(e, "municipality");
                    String herriaKodeaStr = getElementValue(e, "municipalitycode");
                    int herriaKodea = herriaKodeaStr != null ? Integer.parseInt(herriaKodeaStr) : 0;
                    try {
                        txertatuProbintzia(conn, probintziaKodea, probintziaIzena);
                    } catch (SQLException ex) {
                        if (ex.getErrorCode() != 1) throw ex;
                    }
                    try {
                        txertatuHerria(conn, herriaKodea, herriaIzena);
                    } catch (SQLException ex) {
                        if (ex.getErrorCode() != 1) throw ex;
                    }
                    
                    String sqlKanpina = "INSERT INTO KANPINAK (KODEA, IZENA, DESKRIBAPENA, KOKALEKUA, TELEFONOA, HELBIDEA, EMAILA, WEBGUNEA, KATEGORIA, EDUKIERA, POSTAKODEA, HERRI_KODEA, PROBINTZIA_KODEA, FRIENDLY_URL, PHYSICAL_URL, DATA_XML, METADATA_XML, ZIP_FILE) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                    try (PreparedStatement pstmtKanpina = conn.prepareStatement(sqlKanpina)) {
                        
                        pstmtKanpina.setString(1, kodea);
                        pstmtKanpina.setString(2, izena);
                        pstmtKanpina.setString(3, deskribapena);
                        pstmtKanpina.setString(4, kokalekua);
                        pstmtKanpina.setString(5, telefonoa);
                        pstmtKanpina.setString(6, helbidea);
                        pstmtKanpina.setString(7, emaila);
                        pstmtKanpina.setString(8, webgunea);
                        pstmtKanpina.setString(9, kategoria);
                        pstmtKanpina.setInt(10, edukiera);
                        pstmtKanpina.setString(11, postaKodea);
                        pstmtKanpina.setInt(12, herriaKodea);
                        pstmtKanpina.setInt(13, probintziaKodea);
                        pstmtKanpina.setString(14, getElementValue(e, "friendlyUrl"));
                        pstmtKanpina.setString(15, getElementValue(e, "physicalUrl"));
                        pstmtKanpina.setString(16, getElementValue(e, "dataXML"));
                        pstmtKanpina.setString(17, getElementValue(e, "metadataXML"));
                        pstmtKanpina.setString(18, getElementValue(e, "zipFile"));

                        pstmtKanpina.executeUpdate();
                    }
                    txertatuKanpinEtiketak(conn, e, kodea);
                }
            }
            System.out.println("Inportazioa amaituta.");
        } catch (Exception e) {
            e.printStackTrace();
            System.err.println("Errore kritikoa gertatu da. Inportazioa ez da osatu.");
        } finally {
            if (conn != null) {
                try {
                    conn.close();
                } catch (SQLException e) { /* isildu */ }
            }
        }
    }
    
    private void txertatuHerria(Connection conn, int kodea, String izena) throws SQLException {
        String sql = "INSERT INTO HERRIAK (KODEA, IZENA) VALUES (?, ?)";
        try (PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setInt(1, kodea);
            pstmt.setString(2, izena);
            pstmt.executeUpdate();
        }
    }
    private void txertatuProbintzia(Connection conn, int kodea, String izena) throws SQLException {
        String sql = "INSERT INTO PROBINTZIAK (KODEA, IZENA) VALUES (?, ?)";
        try (PreparedStatement pstmt = conn.prepareStatement(sql)) {
            pstmt.setInt(1, kodea);
            pstmt.setString(2, izena);
            pstmt.executeUpdate();
        }
    }
    private void txertatuKanpinEtiketak(Connection conn, Element e, String kanpinKodea) throws SQLException {
        
        Map<String, String> zerbitzuakEtaErabiltzaileak = new HashMap<>();
        zerbitzuakEtaErabiltzaileak.put("restaurant", getElementValue(e, "restaurant"));
        zerbitzuakEtaErabiltzaileak.put("store", getElementValue(e, "store"));
        zerbitzuakEtaErabiltzaileak.put("fisiko_egokitua", getElementValue(e, "physical", "0").equals("0") ? null : "1");
        
        String sqlSelect = "SELECT ID FROM ETIKETAK WHERE ETIKETA = ?";
        String sqlInsertEtiketa = "INSERT INTO ETIKETAK (ETIKETA) VALUES (?)";
        String sqlInsertLotura = "INSERT INTO KANPIN_ETIKETAK (ID_ETIKETA, KANPIN_KODEA) VALUES (?, ?)";

        try (PreparedStatement pstmtSelect = conn.prepareStatement(sqlSelect);
             PreparedStatement pstmtInsertEtiketa = conn.prepareStatement(sqlInsertEtiketa, new String[]{"ID"});
             PreparedStatement pstmtInsertLotura = conn.prepareStatement(sqlInsertLotura)) {
            
            for (Map.Entry<String, String> entry : zerbitzuakEtaErabiltzaileak.entrySet()) {
                String etiketaIzena = entry.getKey();
                String balioa = entry.getValue();
                if (balioa != null) {
                    int etiketaID = -1;
                    pstmtSelect.setString(1, etiketaIzena);
                    try (ResultSet rs = pstmtSelect.executeQuery()) {
                        if (rs.next()) {
                            etiketaID = rs.getInt("ID");
                        }
                    }
                    if (etiketaID == -1) {
                        pstmtInsertEtiketa.setString(1, etiketaIzena);
                        pstmtInsertEtiketa.executeUpdate();
                        try (ResultSet generatedKeys = pstmtInsertEtiketa.getGeneratedKeys()) {
                            if (generatedKeys.next()) {
                                etiketaID = generatedKeys.getInt(1);
                            }
                        }
                    }
                    if (etiketaID != -1) {
                        try {
                            pstmtInsertLotura.setInt(1, etiketaID);
                            pstmtInsertLotura.setString(2, kanpinKodea);
                            pstmtInsertLotura.executeUpdate();
                        } catch (SQLException ex) {
                             if (ex.getErrorCode() != 1) {
                                 throw ex;
                             }
                        }
                    }
                }
            }
        }
    }
}