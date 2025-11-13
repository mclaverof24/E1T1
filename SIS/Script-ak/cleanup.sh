#!/bin/bash

# Aldagaiak
TMP_DIR="/tmp"
LOG_DIR="/var/log"
DAYS_TMP=7
DAYS_LOG=30
LOG_FILE="/var/log/garbitze.log"
TIMESTAMP=$(date +%Y%m%d_%H%M%S)

# Garbiketa prozesua hasi
echo "----------------------------------------------------" >> $LOG_FILE
echo "Garbiketa hasi da: $TIMESTAMP" >> $LOG_FILE

echo "1. /tmp karpetako fitxategiak ($DAYS_TMP egun baino zaharragoak) ezabatzen..." >> $LOG_FILE
# find komandoa erabili ezabatzeko (izenekoak ez ditugu ezabatuko)
find $TMP_DIR -type f -mtime +$DAYS_TMP -delete -print >> $LOG_FILE 2>&1

echo "2. /var/log karpetako .log fitxategiak ($DAYS_LOG egun baino zaharragoak) ezabatzen..." >> $LOG_FILE
# find komandoa erabili .log fitxategiak ezabatzeko
find $LOG_DIR -type f -name "*.log" -mtime +$DAYS_LOG -delete -print >> $LOG_FILE 2>&1

echo "Garbiketa amaitu da." >> $LOG_FILE
echo "----------------------------------------------------" >> $LOG_FILE