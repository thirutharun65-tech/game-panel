# 🎮 VS Code Integrated Setup Guide

## ⚡ Automatic Panel Setup (One Command!)

The headshot panel will **automatically open** when you run your Free Fire game in VS Code!

---

## 🚀 Quick Start (30 seconds)

### **For Windows:**

1. **Download and open in VS Code:**
   ```bash
   git clone https://github.com/thirutharun65-tech/game-panel.git
   cd game-panel
   code .
   ```

2. **Run setup script:**
   ```bash
   setup.bat
   ```

3. **Open in Unity:**
   - File → Open Project
   - Select your **Free Fire game folder**
   - Press **Play** ▶️

4. **✅ Panel auto-opens!**

---

### **For Mac/Linux:**

1. **Download and open in VS Code:**
   ```bash
   git clone https://github.com/thirutharun65-tech/game-panel.git
   cd game-panel
   code .
   ```

2. **Make script executable:**
   ```bash
   chmod +x setup.sh
   ```

3. **Run setup script:**
   ```bash
   ./setup.sh
   ```

4. **Open in Unity and Press Play** ▶️

---

## 📋 What Happens Automatically

```
Game Starts
    ↓
AutoPanelInitializer runs
    ↓
✅ Protection System Activated
    ↓
✅ Headshot Panel Created
    ↓
✅ Game Manager Initialized
    ↓
✅ Panel Appears in Top-Right Corner
    ↓
Ready to Play!
```

---

## 🎮 Using the Panel in VS Code

### **The Panel Appears Automatically**

When you press **Play** in Unity:

```
┌─────────────────────────────┐
│  HEADSHOTS         [_][█][X]│
├─────────────────────────────┤
│ Headshots: 0                │
│ Kills: 0                    │
│ Accuracy: 0%                │
└─────────────────────────────┘
```

### **Keyboard Shortcuts:**

| Key | Action |
|-----|--------|
| **T** | Test Headshot (for testing) |
| **K** | Test Kill (for testing) |
| **R** | Reset Stats |
| **M** | Minimize Panel |
| **X** | Maximize Panel |
| **C** | Close Panel |

---

## 🔧 Manual Integration (If Auto Setup Doesn't Work)

### **Step 1: Copy Files**

Copy all these files to your Free Fire project:

```
Assets/Scripts/
├── AutoPanelInitializer.cs    ← Auto-runs on game start!
├── HeadshotPanel.cs
├── HeadshotPanelUI.cs
├── GameManager.cs
├── DamageSystem.cs
├── WeaponSystem.cs
├── PlayerHealth.cs
├── Enemy.cs
├── CodeProtection.cs
├── DataEncryption.cs
└── AntiCheatSystem.cs
```

### **Step 2: Just Press Play!**

That's it! The panel will automatically initialize.

---

## 📊 VS Code Extensions Recommended

For better Unity development in VS Code:

1. **C# Dev Kit**
   ```
   Command Palette → Extensions → Install "C# Dev Kit"
   ```

2. **Debugger for Unity**
   ```
   Command Palette → Extensions → Install "Debugger for Unity"
   ```

3. **Unity Tools**
   ```
   Command Palette → Extensions → Install "Unity Tools"
   ```

---

## 🧪 Testing the Panel

### **Test 1: Verify Auto-Initialization**

Open **Console** in Unity Editor:
```
Look for these messages:
✅ [AUTO-INIT] Starting Headshot Panel Initialization...
🔐 Protection Manager Created
🎨 Headshot Panel UI Created
✅ Game Manager Created and Configured
✅ Panel Ready! Press Play to Start
```

### **Test 2: Test Headshot Counter**

1. Press **Play** in Unity
2. Press **T** on keyboard
3. Panel updates: "Headshots: 1"

### **Test 3: Test Kill Counter**

1. Press **K** on keyboard
2. Panel updates: "Kills: 1"

### **Test 4: Test Reset**

1. Press **R** on keyboard
2. Stats reset: "Headshots: 0, Kills: 0"

---

## ⚙️ Configuration Files

### **Edit in VS Code:**

**1. `AutoPanelInitializer.cs`** - Auto-startup settings
```csharp
[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
public static void AutoInitialize()
{
    // Customize auto-init here
}
```

**2. `DataEncryption.cs`** - Change encryption key
```csharp
private static readonly string encryptionKey = "YourSecretKey123";
```

**3. `DamageSystem.cs`** - Change damage values
```csharp
private float headDamage = 100f;
private float bodyDamage = 50f;
```

---

## 🐛 Troubleshooting

### **Panel doesn't appear**

✓ **Solution 1:** Check Console for errors
```
View → Console
Look for red error messages
```

✓ **Solution 2:** Verify TextMeshPro is imported
```
Window → TextMeshPro → Import TMP Essentials
```

✓ **Solution 3:** Check if scene has Canvas
```
If not, create one: Hierarchy → Create Empty → Add Canvas component
```

---

### **Auto-init script not running**

✓ Make sure `AutoPanelInitializer.cs` is in `Assets/Scripts/`

✓ Check file has no compilation errors (yellow/red icons)

✓ Restart Unity Editor if needed

---

### **Panel appears but doesn't track hits**

✓ Verify enemy colliders are named correctly:
- "head" for head
- "body" for body
- "leg" for legs

✓ Check DamageSystem is attached to player

✓ Verify weapon system is calling `ApplyDamage()`

---

## 📱 Deploy to Mobile

### **Android:**
```bash
1. File → Build Settings
2. Platform → Android
3. Player Settings → IL2CPP backend
4. Build and Run
```

### **iOS:**
```bash
1. File → Build Settings
2. Platform → iOS
3. Build XCode project
4. Open in Xcode and build
```

Panel works the same on mobile! 📲

---

## 🎯 Pro Tips

### **Tip 1: Use VS Code Debugging**

```bash
# Install Debugger for Unity
# Press F5 to attach debugger while game runs
```

### **Tip 2: Live Edit**

While game is running in Unity:
1. Edit script in VS Code
2. Save (Ctrl+S)
3. Recompile automatically in Unity

### **Tip 3: Use Keyboard Shortcuts**

```
Ctrl+Shift+B → Build project
Ctrl+K Ctrl+0 → Fold all code
Ctrl+/ → Toggle comment
```

---

## 📚 Full Documentation Links

- [Unity Official Docs](https://docs.unity3d.com/)
- [VS Code Unity Setup](https://code.visualstudio.com/docs/other/unity)
- [C# in VS Code](https://github.com/OmniSharp/omnisharp-vscode)

---

## ✅ Checklist Before Going Live

- [ ] AutoPanelInitializer.cs in Assets/Scripts/
- [ ] All 11 scripts copied
- [ ] Panel appears on Play
- [ ] Headshots counted correctly
- [ ] Protection system active
- [ ] No console errors
- [ ] Tested on target platform
- [ ] Built APK/IPA successfully

---

**Now your headshot panel is ready in VS Code!** 🚀

Just press Play and watch it appear automatically!

Need more help? Check the console for debug messages! 🐛
