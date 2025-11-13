#!/bin/bash

# Aldagaiak definitu
SOURCE_DIR="/srv/data"
TARGET_DIR="/srv/backup"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)
BACKUP_FILE="$TARGET_DIR/babeskopia_$TIMESTAMP.tar.gz"
LOG_FILE="/var/log/babeskopia.log"

# Babeskopia karpeta existitzen dela ziurtatu
mkdir -p $TARGET_DIR

# Babeskopia prozesua hasi eta log-ean idatzi
echo "----------------------------------------------------" >> $LOG_FILE
echo "Babeskopia hasi da: $TIMESTAMP" >> $LOG_FILE

# tar komandoa erabili konprimitzeko eta kopiatzeko
tar -czf $BACKUP_FILE $SOURCE_DIR 2>> $LOG_FILE

# Emaitza egiaztatu
if [ $? -eq 0 ]; then
    echo "Babeskopia ondo burutu da: $BACKUP_FILE" >> $LOG_FILE
else
    echo "ERROREA: Babeskopia ez da burutu. Ikusi komandoaren irteera." >> $LOG_FILE
fi

echo "Babeskopia amaitu da." >> $LOG_FILE
echo "----------------------------------------------------" >> $LOG_FILE