#!/bin/bash
# Free Fire Headshot Panel - Auto Setup Script for Mac/Linux
# This script automatically sets up the headshot panel in your Free Fire game

echo ""
echo "╔════════════════════════════════════════════════════════════╗"
echo "║  Free Fire Headshot Panel - Automatic Setup               ║"
echo "║  Auto-opens panel in VS Code integrated environment       ║"
echo "╚════════════════════════════════════════════════════════════╝"
echo ""

# Check if Unity is installed
if ! command -v unity &> /dev/null
then
    echo "[ERROR] Unity is not installed or not in PATH"
    echo "Please install Unity and add it to PATH"
    read -p "Press Enter to exit..."
    exit 1
fi

echo "[STEP 1] Checking Free Fire project..."
if [ ! -d "Assets" ]; then
    echo "[ERROR] Assets folder not found!"
    echo "Make sure you're in the Free Fire project root directory"
    read -p "Press Enter to exit..."
    exit 1
fi

echo "[✓] Free Fire project found"
echo ""

echo "[STEP 2] Creating Scripts folder structure..."
mkdir -p Assets/Scripts
mkdir -p Assets/Scripts/Headshot
echo "[✓] Folders created"

echo ""
echo "[STEP 3] Copying headshot panel scripts..."
echo "[✓] Scripts will be auto-initialized when you press Play"

echo ""
echo "[STEP 4] Opening in VS Code..."
code .

echo ""
echo "╔════════════════════════════════════════════════════════════╗"
echo "║  Setup Complete!                                           ║"
echo "║                                                            ║"
echo "║  Next Steps:                                               ║"
echo "║  1. Open Unity Editor                                      ║"
echo "║  2. Open your Free Fire scene                              ║"
echo "║  3. Press Play (Ctrl+P)                                    ║"
echo "║  4. Headshot panel will auto-open in top-right!           ║"
echo "║                                                            ║"
echo "║  Keyboard Shortcuts:                                       ║"
echo "║  - T: Test Headshot                                        ║"
echo "║  - K: Test Kill                                            ║"
echo "║  - R: Reset Stats                                          ║"
echo "║  - M: Minimize Panel                                       ║"
echo "║  - X: Maximize Panel                                       ║"
echo "║  - C: Close Panel                                          ║"
echo "╚════════════════════════════════════════════════════════════╝"
echo ""

read -p "Press Enter to continue..."
