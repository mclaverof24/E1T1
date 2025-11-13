#!/bin/bash

# Konfigurazioa
SERVICES="apache2 fail2ban"  # Berrabiarazi beharreko zerbitzuak
LOG_FILE="/var/log/maintenance.log"
DATE=$(date +"%Y-%m-%d %H:%M:%S")

echo "--- $DATE - Mantentze-lanak hasi dira ---" >> $LOG_FILE

# 1. Zerbitzu kritikoak berrabiarazi
echo "$DATE - Zerbitzuak berrabiarazten: $SERVICES" >> $LOG_FILE
for service in $SERVICES; do
    echo "$DATE - Berrabiarazten $service..." >> $LOG_FILE
    sudo systemctl restart "$service" 2>&1 | while read line ; do
        echo "$DATE - $service (Restart): $line" >> $LOG_FILE
    done
    
    # Egoera egiaztatu
    status=$(systemctl is-active "$service")
    echo "$DATE - $service egoera: $status" >> $LOG_FILE
    if [ "$status" != "active" ]; then
        echo "$DATE - ⚠️ OHARRA: $service EZ da martxan jarri!" >> $LOG_FILE
    fi
done

# 2. Log nagusiak egiaztatu (azken 50 lerroak)
echo "$DATE - Log-ak egiaztatzen (azken 50 lerroak):" >> $LOG_FILE

# Fail2ban log-a (blokeo adierazgarriak ikusteko)
echo "$DATE - ### /var/log/fail2ban.log ###" >> $LOG_FILE
tail -n 50 /var/log/fail2ban.log >> $LOG_FILE

# Apache error log-a (web zerbitzariaren akatsak ikusteko)
echo "$DATE - ### /var/log/apache2/error.log ###" >> $LOG_FILE
tail -n 50 /var/log/apache2/error.log >> $LOG_FILE

echo "$DATE - Mantentze-lanak ondo amaitu dira." >> $LOG_FILE
echo "--- Mantentze-lanak amaitu dira ---" >> $LOG_FILE