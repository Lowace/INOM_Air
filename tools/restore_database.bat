@echo off
title INOM Air - 1-Click Database Restore
color 0E
echo ======================================================================
echo              INOM AIR - 1-CLICK DATABASE RESTORE TOOL
echo ======================================================================
echo.

set MYSQL=""
if exist "C:\xampp\mysql\bin\mysql.exe" set MYSQL="C:\xampp\mysql\bin\mysql.exe"
if exist "D:\xampp\mysql\bin\mysql.exe" set MYSQL="D:\xampp\mysql\bin\mysql.exe"
if exist ".\mysql\bin\mysql.exe" set MYSQL=".\mysql\bin\mysql.exe"
if exist "..\mysql\bin\mysql.exe" set MYSQL="..\mysql\bin\mysql.exe"

if %MYSQL%=="" (
    echo [ERROR] mysql.exe not found! Make sure XAMPP is in C:\xampp.
    pause
    exit /b 1
)

set SQL_FILE="%~dp0..\inomairtest_db.sql"
if exist "%~dp0..\inomairtest_db_backup.sql" (
    set SQL_FILE="%~dp0..\inomairtest_db_backup.sql"
    echo [FOUND] Using latest backup file: inomairtest_db_backup.sql
) else (
    echo [FOUND] Using default schema file: inomairtest_db.sql
)

if not exist %SQL_FILE% (
    echo [ERROR] Could not find inomairtest_db.sql at %SQL_FILE%!
    pause
    exit /b 1
)

echo Importing database schema and sample data...
%MYSQL% -u root --default-character-set=utf8mb4 < %SQL_FILE%

if %errorlevel% equ 0 (
    echo.
    echo ======================================================================
    echo [SUCCESS] inomairtest_db successfully restored to MySQL!
    echo ======================================================================
) else (
    echo.
    echo [FAILED] Make sure MySQL is running before restoring.
)
echo.
pause

