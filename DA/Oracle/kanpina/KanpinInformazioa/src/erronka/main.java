package erronka;

import java.util.Properties;

public class main {

    public static void main(String[] args) {
    	
        Properties config = konfigurazioa.irakurri();
        if (config.isEmpty()) {
            System.err.println("Ezin izan da konfigurazioa kargatu. Aplikazioa amaitu da.");
            return;
        }
        System.out.println("\n--- Datuen Inportazioa hasi da ---");
        importazioa inportatzailea = new importazioa();
        inportatzailea.inportatu(config);
        
        System.out.println("\n--- Datuen Esportazioa hasi da ---");
        esportazioa esportatzailea = new esportazioa();
        esportatzailea.esportatu(config);
        
        System.out.println("\n--- Aplikazioa amaitu da ---");
    }
}