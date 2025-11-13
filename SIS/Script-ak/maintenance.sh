#!/bin/bash

# Zerbitzuak berrabiarazteko eta log-ak egiaztatzeko script-a

LOG_FILE="/var/log/mantentze.log"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
SERVICES=("apache2" "ssh" "nginx") # Egiaztatu zein zerbitzu erabili

echo "----------------------------------------------------" >> $LOG_FILE
echo "Mantentze-lanak hasi dira: $TIMESTAMP" >> $LOG_FILE

# 1. Zerbitzuak berrabiarazi
for SERVICE in "${SERVICES[@]}"; do
    echo "-> Zerbitzua berrabiarazten: $SERVICE" >> $LOG_FILE
    # systemctl erabiliz (Debian/Ubuntu/CentOS berrietan)
    sudo systemctl restart $SERVICE
    if [ $? -eq 0 ]; then
        echo "   $SERVICE zerbitzua ondo berrabiarazi da." >> $LOG_FILE
    else
        echo "   ERROREA: $SERVICE zerbitzua ez da berrabiarazi. Egiaztatu eskuz." >> $LOG_FILE
    fi
done

# 2. Sistemaren log-ak egiaztatu
echo "" >> $LOG_FILE
echo "-> Azken erroreak egiaztatzen systemd-en..." >> $LOG_FILE
# systemctl erabili 'err' (error) eta 'fail' (huts) mezuak bilatzeko azken orduan
journalctl --since "1 hour ago" -p err -p warning -o short-monotonic | tail -n 20 >> $LOG_FILE

echo "" >> $LOG_FILE
echo "-> Kernel log-ak egiaztatzen (dmesg)..." >> $LOG_FILE
dmesg | tail -n 10 >> $LOG_FILE

echo "Mantentze-lanak amaitu dira." >> $LOG_FILE
echo "----------------------------------------------------" >> $LOG_FILE