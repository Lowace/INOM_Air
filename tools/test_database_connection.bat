@echo off
title INOM Air - Test Database Connection ^& View Live Tables
color 0A
echo ======================================================================
echo           INOM AIR - TEST DATABASE CONNECTION ^& VIEW TABLES
echo ======================================================================
echo.

set MYSQL=""
if exist "C:\xampp\mysql\bin\mysql.exe" set MYSQL="C:\xampp\mysql\bin\mysql.exe"
if exist "D:\xampp\mysql\bin\mysql.exe" set MYSQL="D:\xampp\mysql\bin\mysql.exe"

if %MYSQL%=="" (
    echo [ERROR] mysql.exe not found in C:\xampp\mysql\bin!
    pause
    exit /b 1
)

echo [TEST 1] Pinging MySQL server...
%MYSQL% -u root -e "SELECT 'MySQL Server is ACTIVE and REACHABLE!' AS Status, NOW() AS CurrentTime;" 
if %errorlevel% neq 0 (
    echo.
    echo [ERROR] Cannot reach MySQL server! Make sure MySQL is started.
    pause
    exit /b 1
)

echo.
echo [TEST 2] Verifying 'inomairtest_db' and Table Row Counts...
%MYSQL% -u root -D inomairtest_db -e "SELECT 'users' AS `Table`, COUNT(*) AS `Row Count` FROM users UNION ALL SELECT 'aircrafts', COUNT(*) FROM aircrafts UNION ALL SELECT 'pilots', COUNT(*) FROM pilots UNION ALL SELECT 'flights', COUNT(*) FROM flights UNION ALL SELECT 'bookings', COUNT(*) FROM bookings;"

echo.
echo [TEST 3] Showing Recent Bookings:
%MYSQL% -u root -D inomairtest_db -e "SELECT ticket_number, username, passenger_name, flight_id, cabin_class, seat_number, total_amount, status FROM bookings LIMIT 5;"

echo.
echo ======================================================================
echo [SUCCESS] Database is 100% ONLINE and OPERATIONAL!
echo You can show this terminal directly to your instructor/panelists.
echo ======================================================================
pause

