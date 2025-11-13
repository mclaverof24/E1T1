#!/bin/bash

# Konfigurazioa
SOURCE_DIR="/srv/data"
TARGET_DIR="/srv/backup"
LOG_FILE="/var/log/backup.log"
DATE=$(date +"%Y-%m-%d %H:%M:%S")

# Sorkuntza: Backup karpeta ez bada existitzen, sortu
if [ ! -d "$TARGET_DIR" ]; then
    mkdir -p "$TARGET_DIR"
    echo "$DATE - $TARGET_DIR karpeta sortu da." >> $LOG_FILE
fi

echo "--- $DATE - Babeskopia hasi da ---" >> $LOG_FILE

# rsync erabiliz babeskopia inkrementala
# -a: artxibo modua (mantendu baimenak, jabeak, etab.)
# -v: xehetasunak (verbose)
# --delete: Ezabatu jatorrian ez dauden fitxategiak helburuan
rsync -av --delete "$SOURCE_DIR/" "$TARGET_DIR/" 2>&1 | while read line ; do
    echo "$DATE - rsync: $line" >> $LOG_FILE
done

EXIT_CODE=$?

if [ $EXIT_CODE -eq 0 ]; then
    echo "$DATE - Babeskopia ondo amaitu da (Kodea: $EXIT_CODE)." >> $LOG_FILE
else
    echo "$DATE - ⚠️ AKATSA: Babeskopia txarto amaitu da (Kodea: $EXIT_CODE)." >> $LOG_FILE
fi

echo "--- Babeskopia amaitu da ---" >> $LOG_FILE