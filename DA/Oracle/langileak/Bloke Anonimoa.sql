SELECT
    l.nan AS nan_zenbakia,
    l.izena,
    l.abizena,
    
    h.helbidea || ', ' || h.postakodea || ' (' || h.probintzia || ')' AS helbidea_osoa,
    h.herria AS herria,
    
    NVL(
        (
            SELECT LISTAGG(t.telefono_zenbakia, ', ')
                   WITHIN GROUP (ORDER BY t.telefono_zenbakia)
            FROM telefono_typ t
            WHERE t.langile_nan = l.nan
        ),
        'Ez du telefonorik'
    ) AS telefonoak,
    
    TO_CHAR(l.soldata_oinarria, '999G999D00') AS soldata_oinarria,
    TO_CHAR(soldata_totala_kalkulatu(l.soldata_oinarria, l.kontratatze_data), '999G999D00') AS soldata_totala

FROM 
    langile_typ l
    JOIN administrari_typ a ON l.nan = a.langile_nan
    JOIN helbide_typ h ON l.nan = h.langile_nan;


