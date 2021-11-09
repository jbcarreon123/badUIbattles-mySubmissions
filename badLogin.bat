@echo off
cls
echo.
if not exist "%temp%\badCLI1" ( mkdir "%temp%\badCLI1")
if exist "%temp%\badCLI1\cred.bat" ( goto LogIn)
:name
echo   Enter your name
set /p "namei=  > "
%namei%> "%temp%\badCLI1\1.log"
set /p "name=" <"%temp%\badCLI1\1.log"
if "%name%"=="" ( goto name)
:pass
echo   Enter your password
set /p "namei=  > "
%namei%> "%temp%\badCLI1\2.log"
set /p "pass=" <"%temp%\badCLI1\2.log"
if "%pass%"=="" ( goto pass)
:verify
set "rnd=%random%"
echo   Verify it's not an bot: %rnd%
set /p "namei=  > "
%namei%> "%temp%\badCLI1\3.log"
set /p "verify=" <"%temp%\badCLI1\3.log"
if "%verify%"=="" ( goto verify)
if not "%verify%"=="%rnd%" ( goto verify)
:finished
(echo set "namer=%name%"
echo set "passr=%pass%") >"%temp%\badCLI1\cred.bat"
echo   Successfully created.
:LogIn
:namel
echo   Enter your name
set /p "namei=  > "
%namei%> "%temp%\badCLI1\4.log"
set /p "name=" <"%temp%\badCLI1\4.log"
if "%name%"=="register" ( echo   You can only register once. & goto namel)
if "%name%"=="" ( goto namel)
:passl
echo   Enter your password
set /p "namei=  > "
%namei%> "%temp%\badCLI1\5.log"
set /p "pass=" <"%temp%\badCLI1\5.log"
if "%pass%"=="register" ( echo   You can only register once. & goto passl)
if "%pass%"=="" ( goto passl)
:verifyl
set "rnd=%random%"
echo   Verify it's not an bot: %rnd%
set /p "namei=  > "
%namei%> "%temp%\badCLI1\6.log"
set /p "verify=" <"%temp%\badCLI1\6.log"
if "%verify%"=="register" ( echo   You can only register once. & goto verifyl)
if "%verify%"=="" ( goto verifyl)
if not "%verify%"=="%rnd%" ( echo   Try again. & goto verifyl)
:getcreds
call "%temp%\badCLI1\cred.bat"
if not "%name%"=="%namer%" ( echo   Invalid username or password & goto LogIn)
if not "%pass%"=="%passr%" ( echo   Invalid username or password & goto LogIn)
echo   Success.
timeout 3 /nobreak >nul
cmd
exit