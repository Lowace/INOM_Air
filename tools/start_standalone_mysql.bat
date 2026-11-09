@echo off
title INOM Air - Direct MySQL Server Runner
color 0B
echo ======================================================================
echo           INOM AIR - DIRECT STANDALONE MYSQL SERVER LAUNCHER
echo ======================================================================
echo.
echo Searching for MySQL binary...

set MYSQLD=""
if exist "C:\xampp\mysql\bin\mysqld.exe" set MYSQLD="C:\xampp\mysql\bin\mysqld.exe"
if exist "D:\xampp\mysql\bin\mysqld.exe" set MYSQLD="D:\xampp\mysql\bin\mysqld.exe"
if exist ".\mysql\bin\mysqld.exe" set MYSQLD=".\mysql\bin\mysqld.exe"
if exist "..\mysql\bin\mysqld.exe" set MYSQLD="..\mysql\bin\mysqld.exe"

if %MYSQLD%=="" (
    echo [ERROR] mysqld.exe could not be found in C:\xampp\mysql\bin or local folder!
    echo Please make sure XAMPP is installed in C:\xampp.
    pause
    exit /b 1
)

echo [FOUND] MySQL at %MYSQLD%
echo.
echo Starting MySQL Server on Port 3306...
echo (Keep this window OPEN while running INOM Air!)
echo.
%MYSQLD% --standalone --console
pause
