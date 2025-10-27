package erronka;

import java.util.Properties;

/**
 * Aplikazioaren sarrera-puntua.
 * Konfigurazioa kargatzen du, datuak inportatzen (XML -> DB) eta datuak esportatzen (DB -> CSV/XML).
 */
public class main_inportazioa {

    public static void main(String[] args) {
    	
        // 1. Konfigurazioa kargatu
        // konfigurazioa klaseko irakurri() metodo estatikoaren bidez fitxategia irakurri.
        Properties config = konfigurazioa.irakurri();
        
        // Konfigurazioa hutsik badago, errorea erakutsi eta aplikazioa amaitu.
        if (config.isEmpty()) {
            System.err.println("Ezin izan da konfigurazioa kargatu. Aplikazioa amaitu da.");
            return;
        }
        
        // 2. Datuen Inportazioa
        System.out.println("\n--- Datuen Inportazioa hasi da ---");
        
        // importazioa klasea instantziatu eta inportazio prozesua hasi (XML -> DB).
        importazioa inportatzailea = new importazioa();
        inportatzailea.inportatu(config);
        
        // 4. Amaiera
        System.out.println("\n--- Aplikazioa amaitu da ---");
    }
}
