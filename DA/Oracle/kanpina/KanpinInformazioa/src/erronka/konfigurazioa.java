package erronka;

import java.io.FileInputStream;
import java.util.Properties;

public class konfigurazioa {
    private static final String FITXATEGIA = "files/konfigurazio.txt";

    public static Properties irakurri() {
        Properties prop = new Properties();
        try (FileInputStream fis = new FileInputStream(FITXATEGIA)) {
            prop.load(fis);
            System.out.println("Konfigurazioa irakurrita: " + prop.getProperty("xml_fitxategia"));
        } catch (Exception e) {
            e.printStackTrace();
        }
        return prop;
    }
}
