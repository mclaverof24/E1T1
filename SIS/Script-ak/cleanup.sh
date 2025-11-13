#!/bin/bash

# Konfigurazioa
TMP_DAYS=7          # /tmp-n 7 egun baino zaharragoak
LOG_DAYS=30         # /var/log-en 30 egun baino zaharragoak (gz/zip fitxategiak)
LOG_FILE="/var/log/cleanup.log"
DATE=$(date +"%Y-%m-%d %H:%M:%S")

echo "--- $DATE - Garbiketa hasi da ---" >> $LOG_FILE

# 1. /tmp karpetako fitxategiak ezabatu (7 egun baino zaharragoak)
echo "$DATE - /tmp karpeta garbitzen..." >> $LOG_FILE
find /tmp -type f -atime +$TMP_DAYS -delete 2>&1 | while read line ; do
    echo "$DATE - Ezabatua (tmp): $line" >> $LOG_FILE
done

# 2. /var/log karpetako log fitxategi zaharrak ezabatu (30 egun baino zaharragoak, .gz, .zip, .old)
echo "$DATE - /var/log karpeta garbitzen..." >> $LOG_FILE
find /var/log -type f -name "*.gz" -o -name "*.zip" -o -name "*.old" -atime +$LOG_DAYS -delete 2>&1 | while read line ; do
    echo "$DATE - Ezabatua (log): $line" >> $LOG_FILE
done

echo "$DATE - Garbiketa ondo amaitu da." >> $LOG_FILE
echo "--- Garbiketa amaitu da ---" >> $LOG_FILE