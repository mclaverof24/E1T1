package erronka;

import java.io.FileInputStream;
import java.util.Properties;

/**
 * Konfigurazio fitxategia irakurtzeaz arduratzen den klasea.
 * Fitxategi honek (konfigurazio.txt) datu-basearen konexio-parametroak
 * (DB_URL, DB_USER, DB_PASS) eta XML fitxategiaren bidea (XML_FITXATEGIA)
 * ditu.
 */
public class konfigurazioa {
    private static final String FITXATEGIA = "files/konfigurazio.txt";

    /**
     * 'konfigurazio.txt' fitxategiko propietate guztiak irakurri eta kargatzen ditu.
     * * @return Properties objektua, kargatutako konfigurazio guztiak dituena.
     */
    public static Properties irakurri() {
        Properties prop = new Properties();
        try (FileInputStream fis = new FileInputStream(FITXATEGIA)) {
            prop.load(fis);
            System.out.println("Konfigurazioa irakurrita: " + prop.getProperty("xml_fitxategia"));
            
        } catch (Exception e) {
            // Errore kasuan (adibidez, fitxategia ez badago edo irakurri ezin bada),
            // errorearen traza inprimatzen da, arazketa lanetarako.
            System.err.println("Errorea konfigurazio fitxategia irakurtzean (" + FITXATEGIA + ")");
            e.printStackTrace();
        }
        
        return prop;
    }
}