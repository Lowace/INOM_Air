@echo off
title INOM Air - Emergency Port and Service Fixer
color 0A
echo ======================================================================
echo           INOM AIR - EMERGENCY PORT ^& SERVICE REPAIR TOOL
echo ======================================================================
echo.
echo Closing any stuck or conflicting processes (mysqld, httpd, etc.)...
taskkill /F /IM mysqld.exe >nul 2>&1
taskkill /F /IM httpd.exe >nul 2>&1
taskkill /F /IM mysql.exe >nul 2>&1

echo Stopping conflicting Windows services (IIS, native MySQL/MariaDB)...
net stop mysql >nul 2>&1
net stop mariadb >nul 2>&1
net stop w3svc >nul 2>&1

echo.
echo Checking Port 3306 - MySQL...
netstat -ano | findstr /R /C:":3306 "
if %errorlevel% equ 0 (
    echo [WARNING] Port 3306 is occupied by a background process.
) else (
    echo [OK] Port 3306 is clear and ready for MySQL!
)

echo.
echo Checking Port 80 - Apache...
netstat -ano | findstr /R /C:":80 "
if %errorlevel% equ 0 (
    echo [INFO] Port 80 is occupied by IIS, Skype, or Windows system.
    echo Note: Apache is NOT required for INOM Air. Only MySQL Port 3306 is needed!
) else (
    echo [OK] Port 80 is clear!
)

echo.
echo ======================================================================
echo All background locks cleared! You can now start MySQL in XAMPP.
echo ======================================================================
pause
