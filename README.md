# Headshot Panel for Free Fire Game

Real game integration for C# headshot tracking panel.

## 📁 Files Included

1. **HeadshotPanel.cs** - Core logic for tracking headshots
2. **HeadshotPanelUI.cs** - UI management and display
3. **GameManager.cs** - Integration manager
4. **README.md** - Documentation

## 🎮 How to Integrate Into Your Game

### Step 1: Setup in Unity Editor
1. Create a Canvas in your scene
2. Add an Image for the panel background
3. Add TextMeshPro text elements:
   - Title text
   - Stats text (headshots, kills, accuracy)
4. Add Buttons:
   - Minimize button
   - Maximize button
   - Close button

### Step 2: Attach Scripts
1. Attach `HeadshotPanel.cs` to the panel GameObject
2. Attach `HeadshotPanelUI.cs` to the UI container
3. Attach `GameManager.cs` to a persistent GameObject

### Step 3: Wire Up References
In Inspector, assign:
- HeadshotPanel script → UI text fields and buttons
- HeadshotPanelUI script → title, stats text, buttons
- GameManager script → HeadshotPanel and HeadshotPanelUI references

### Step 4: Call From Your Weapon/Damage Script

```csharp
// When player shoots and hits head
if (hitLocation == HitLocation.Head)
{
    GameManager.Instance.OnPlayerHeadshot();
}
else
{
    GameManager.Instance.OnPlayerKill();
}
```

## 🎯 Key Methods

### HeadshotPanel
```csharp
headshotPanel.AddHeadshot();      // Add headshot count
headshotPanel.AddKill();           // Add kill count
headshotPanel.ResetStats();        // Reset all stats
headshotPanel.OpenPanel();         // Show panel
headshotPanel.ClosePanel();        // Hide panel
```

### GameManager
```csharp
GameManager.Instance.OnPlayerHeadshot();  // Called on headshot
GameManager.Instance.OnPlayerKill();      // Called on kill
GameManager.Instance.ResetStats();        // Reset everything
```

## 🎨 Customization

### Change Colors
Edit in `HeadshotPanelUI.cs` → `SetupPanelStyle()`:
```csharp
panelImage.color = new Color(0.1f, 0.1f, 0.1f, 0.8f);  // Background
titleText.color = Color.yellow;                         // Title
statsText.color = Color.white;                          // Stats
```

### Change Panel Size
Edit in `HeadshotPanelUI.cs`:
```csharp
private Vector2 normalSize = new Vector2(400, 300);
private Vector2 minimizedSize = new Vector2(150, 80);
```

### Add Sound Effects
Add in `HeadshotPanel.cs` → `ShowHeadshotNotification()`:
```csharp
AudioSource.PlayClipAtPoint(headshotSound, transform.position);
```

## ✅ Features

- ✅ Real-time headshot counter
- ✅ Kill counter
- ✅ Accuracy percentage calculation
- ✅ Minimize/Maximize panel
- ✅ Open/Close panel visibility
- ✅ Stats reset
- ✅ Visual notifications

## 📋 Requirements

- Unity 2020.3 or higher
- TextMeshPro (built-in)
- UI Canvas system
- C# scripting

---

**Version:** 1.0  
**Created for:** Free Fire Game  
**Author:** thirutharun65-tech
