package erronka;

import java.util.Properties;

/**
 * Aplikazioaren sarrera-puntua.
 * Konfigurazioa kargatzen du, datuak inportatzen (XML -> DB) eta datuak esportatzen (DB -> CSV/XML).
 */
public class main_esportazioa {

    public static void main(String[] args) {
    	
        // 1. Konfigurazioa kargatu
        // konfigurazioa klaseko irakurri() metodo estatikoaren bidez fitxategia irakurri.
        Properties config = konfigurazioa.irakurri();
        
        // Konfigurazioa hutsik badago, errorea erakutsi eta aplikazioa amaitu.
        if (config.isEmpty()) {
            System.err.println("Ezin izan da konfigurazioa kargatu. Aplikazioa amaitu da.");
            return;
        }
        String herriaFiltroa = "69";      
        
        System.out.println("\n--- Datuen Esportazioa hasi da ---");
        System.out.println("Esportazio iragazkia aplikatuta: Herria -> " + herriaFiltroa);
        
        // esportazioa klasea instantziatu eta esportazio prozesua hasi (DB -> CSV eta XML)
        // Iragazki-parametroak pasatzen dira (probintzia eta herria).
        esportazioa esportatzailea = new esportazioa();
        esportatzailea.esportatu(config, herriaFiltroa);
        
        // 4. Amaiera
        System.out.println("\n--- Aplikazioa amaitu da ---");
    }
}
