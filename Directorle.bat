@setlocal enableextensions enabledelayedexpansion
@echo off
if "%2"=="-0" ( goto Final %3)
del "%temp%\Directorle*.txt" >nul
title Directorle                                                                                                                                                                    
echo Please wait. Checking folders.
if exist "%1" (
echo %1> "%temp%\Directorle1.txt"
dir /s /b "%1" /ad >>"%temp%\Directorle1.txt"
) else (
call :FileChecker
)

:0
cls
:1
echo.
echo   Directorle
:2
echo.
echo   What file you want to look up?
set /p "Sel1=[0m  > "
if "%Sel1%"=="" ( goto 0 )
echo.
echo   Looking it up...
set "_FILES=0"
set "_FILESF=0"
set "_FOLDERS=0"
call :FileCheckers %Sel1%
if "%_FILESF%"=="0" (
cls
echo.
echo   Directorle
echo.
echo   Unfortunately, %Sel1% does not exist.
set "Sel1="
goto :2
)
goto :Final

:FileChecker
powershell (Get-PSDrive).Name -match '^^^[a-z]$' >"%temp%\Directorle2.txt"
for /f %%1 in ('type "%temp%\Directorle2.txt"') do ( echo %%1:> "%temp%\Directorle1.txt" & dir /s /b /ad "%%1:" >"%temp%\Directorle1.txt")
goto :EOF

:FileCheckers
for /f %%1 in ('type "%temp%\Directorle1.txt"') do (
set /a "_FOLDERS+=1"
call :FileCheckerss %%1
)
goto :EOF

:FileCheckerss
for /f %%1 in ('dir /b "%1" 2^>nul') do (
set /a "_FILES+=1"
if "%Sel1%"=="%%1" ( set /a "_FILESF+=1" & echo %1\%%1>> "%temp%\Directorle4.txt" )
)
title Directorle ^| Folders: %_FOLDERS%, Files: %_FILES%, Matched: %_FILESF%
goto :EOF

:Final
cls
echo.
echo   Directorle
:Final2
if "%_FILESF%"=="0" (
cls
echo.
echo   Directorle
echo.
echo   Unfortunately, %Sel1% does not exist.
set "Sel1="
goto :2
)
title Directorle                                                                                                                                                                    
echo.
echo   Summary of files and folders:
echo.
echo   Folders found: %_FOLDERS%
echo   Files found:   %_FILES%
echo   Files matched: %_FILESF%
echo.
echo   [O] Open all
echo   [C] Check all
echo   [E] Exit
choice /c:oce /m "" /n
if %errorlevel%==1 ( goto :OpenAll)
if %errorlevel%==2 ( goto :CheckAll)
exit /b

:OpenAll
for /f %%1 in ('type "%temp%\Directorle4.txt"') do start %%1
goto :Finished2

:CheckAll
echo.
for /f %%1 in ('type "%temp%\Directorle4.txt"') do echo   %%1
echo.
echo   Press [ANY KEY] to go back.
pause>nul
goto :Finished2

:Finished2
cls
echo.
echo   Directorle
echo.
echo   Finished.
goto :Final2