CREATE OR REPLACE FUNCTION soldata_totala_kalkulatu (
    p_soldata_oinarria IN NUMBER,
    p_kontratatze_data IN DATE
) RETURN NUMBER
IS
    antzinatasun_urteak INTEGER := 0;
    soldata_totala_kalk NUMBER := 0;
BEGIN
    IF p_kontratatze_data IS NOT NULL THEN
        antzinatasun_urteak := FLOOR(MONTHS_BETWEEN(SYSDATE, p_kontratatze_data) / 12);
        IF antzinatasun_urteak < 0 THEN
            antzinatasun_urteak := 0;
        END IF;
    END IF;

    soldata_totala_kalk := p_soldata_oinarria * (1 + antzinatasun_urteak * 0.02);

    RETURN ROUND(soldata_totala_kalk, 2);
END soldata_totala_kalkulatu;
/ 

