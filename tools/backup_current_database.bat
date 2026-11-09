@echo off
title INOM Air - 1-Click Database Backup
color 0A
echo ======================================================================
echo              INOM AIR - 1-CLICK DATABASE BACKUP TOOL
echo ======================================================================
echo.

set MYSQLDUMP=""
if exist "C:\xampp\mysql\bin\mysqldump.exe" set MYSQLDUMP="C:\xampp\mysql\bin\mysqldump.exe"
if exist "D:\xampp\mysql\bin\mysqldump.exe" set MYSQLDUMP="D:\xampp\mysql\bin\mysqldump.exe"

if %MYSQLDUMP%=="" (
    echo [ERROR] mysqldump.exe not found in C:\xampp\mysql\bin!
    pause
    exit /b 1
)

set BACKUP_FILE="%~dp0..\inomairtest_db_backup.sql"
set MAIN_SQL="%~dp0..\inomairtest_db.sql"

echo Exporting current database (including all bookings, users, and planes)...
%MYSQLDUMP% -u root --databases inomairtest_db --add-drop-database > %BACKUP_FILE%

if %errorlevel% equ 0 (
    copy /Y %BACKUP_FILE% %MAIN_SQL% >nul 2>&1
    echo.
    echo ======================================================================
    echo [SUCCESS] Database successfully backed up!
    echo Saved to: inomairtest_db_backup.sql and inomairtest_db.sql
    echo All your latest bookings, customers, and aircrafts are safely preserved.
    echo ======================================================================
) else (
    echo.
    echo [FAILED] Make sure MySQL is running in XAMPP before backing up.
)
echo.
pause
