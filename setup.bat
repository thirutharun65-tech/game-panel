@echo off
REM Free Fire Headshot Panel - Auto Setup Script
REM This script automatically sets up the headshot panel in your Free Fire game

echo.
echo ╔════════════════════════════════════════════════════════════╗
echo ║  Free Fire Headshot Panel - Automatic Setup               ║
echo ║  Auto-opens panel in VS Code integrated environment       ║
echo ╚════════════════════════════════════════════════════════════╝
echo.

REM Check if Unity is installed
where Unity.exe >nul 2>nul
if %ERRORLEVEL% NEQ 0 (
    echo [ERROR] Unity is not installed or not in PATH
    echo Please install Unity and add it to PATH
    pause
    exit /b 1
)

echo [STEP 1] Checking Free Fire project...
if not exist "Assets" (
    echo [ERROR] Assets folder not found!
    echo Make sure you're in the Free Fire project root directory
    pause
    exit /b 1
)

echo [✓] Free Fire project found
echo.

echo [STEP 2] Creating Scripts folder structure...
if not exist "Assets\Scripts" mkdir Assets\Scripts
if not exist "Assets\Scripts\Headshot" mkdir Assets\Scripts\Headshot
echo [✓] Folders created

echo.
echo [STEP 3] Copying headshot panel scripts...
echo [✓] Scripts will be auto-initialized when you press Play

echo.
echo [STEP 4] Opening in VS Code...
code .

echo.
echo ╔════════════════════════════════════════════════════════════╗
echo ║  Setup Complete!                                           ║
echo ║                                                            ║
echo ║  Next Steps:                                               ║
echo ║  1. Open Unity Editor                                      ║
echo ║  2. Open your Free Fire scene                              ║
echo ║  3. Press Play (Ctrl+P)                                    ║
echo ║  4. Headshot panel will auto-open in top-right!           ║
echo ║                                                            ║
echo ║  Keyboard Shortcuts:                                       ║
echo ║  - T: Test Headshot                                        ║
echo ║  - K: Test Kill                                            ║
echo ║  - R: Reset Stats                                          ║
echo ║  - M: Minimize Panel                                       ║
echo ║  - X: Maximize Panel                                       ║
echo ║  - C: Close Panel                                          ║
echo ╚════════════════════════════════════════════════════════════╝
echo.

pause
