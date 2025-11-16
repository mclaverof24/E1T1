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
        
        String formtaua=args[0];
        String herriaFiltroa = args[1];
        String herriaIzena = args[2];
        
        System.out.println("\n--- Datuen Esportazioa hasi da ---");
        System.out.println("Esportazio formatua aukeratuta -> " + formtaua);
        System.out.println("Esportazio iragazkia aplikatuta: Herria -> " + herriaFiltroa+" - "+ herriaIzena);
        
        // esportazioa klasea instantziatu eta esportazio prozesua hasi (DB -> CSV eta XML)
        // Iragazki-parametroak pasatzen dira (probintzia eta herria).
        esportazioa esportatzailea = new esportazioa();
        esportatzailea.esportatu(config, formtaua, herriaFiltroa, herriaIzena);
        
        // 4. Amaiera
        System.out.println("\n--- Aplikazioa amaitu da ---");
    }
}
