using UnityEngine;
using System;

/// <summary>
/// Auto-Initialize Headshot Panel on Game Start
/// Automatically activates when game runs - no manual setup needed!
/// </summary>
public class AutoPanelInitializer : MonoBehaviour
{
    private static bool hasInitialized = false;
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void AutoInitialize()
    {
        if (hasInitialized) return;
        hasInitialized = true;

        Debug.Log("🎮 [AUTO-INIT] Starting Headshot Panel Initialization...");
        
        // Create Protection Manager
        CreateProtectionManager();
        
        // Create Headshot Panel
        CreateHeadshotPanel();
        
        // Create Game Manager
        CreateGameManager();
        
        Debug.Log("✅ [AUTO-INIT] Panel Ready! Press Play to Start");
    }

    /// <summary>
    /// Auto-create Protection Manager
    /// </summary>
    private static void CreateProtectionManager()
    {
        GameObject protectionObj = new GameObject("ProtectionManager");
        DontDestroyOnLoad(protectionObj);
        
        protectionObj.AddComponent<CodeProtection>();
        protectionObj.AddComponent<DataEncryption>();
        protectionObj.AddComponent<AntiCheatSystem>();
        
        Debug.Log("🔐 Protection Manager Created");
    }

    /// <summary>
    /// Auto-create Headshot Panel UI
    /// </summary>
    private static void CreateHeadshotPanel()
    {
        // Create Canvas
        GameObject canvasObj = new GameObject("HeadshotCanvas");
        Canvas canvas = canvasObj.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        
        CanvasScaler scaler = canvasObj.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        
        // Create Panel
        GameObject panelObj = new GameObject("HeadshotPanel");
        panelObj.transform.SetParent(canvasObj.transform, false);
        
        Image panelImage = panelObj.AddComponent<Image>();
        panelImage.color = new Color(0.1f, 0.1f, 0.1f, 0.8f);
        
        RectTransform panelRect = panelObj.GetComponent<RectTransform>();
        panelRect.anchorMin = new Vector2(1, 1);
        panelRect.anchorMax = new Vector2(1, 1);
        panelRect.pivot = new Vector2(1, 1);
        panelRect.anchoredPosition = new Vector2(-20, -20);
        panelRect.sizeDelta = new Vector2(400, 300);
        
        // Add HeadshotPanel component
        var headshotPanel = panelObj.AddComponent<HeadshotPanel>();
        panelObj.AddComponent<HeadshotPanelUI>();
        
        // Create Title Text
        GameObject titleObj = new GameObject("TitleText");
        titleObj.transform.SetParent(panelObj.transform, false);
        
        TextMeshProUGUI titleText = titleObj.AddComponent<TextMeshProUGUI>();
        titleText.text = "HEADSHOTS";
        titleText.fontSize = 36;
        titleText.color = Color.yellow;
        titleText.alignment = TextAlignmentOptions.TopLeft;
        
        RectTransform titleRect = titleObj.GetComponent<RectTransform>();
        titleRect.anchorMin = Vector2.zero;
        titleRect.anchorMax = Vector2.one;
        titleRect.offsetMin = new Vector2(10, -40);
        titleRect.offsetMax = new Vector2(-10, -10);
        
        // Create Stats Text
        GameObject statsObj = new GameObject("StatsText");
        statsObj.transform.SetParent(panelObj.transform, false);
        
        TextMeshProUGUI statsText = statsObj.AddComponent<TextMeshProUGUI>();
        statsText.text = "Headshots: 0\nKills: 0\nAccuracy: 0%";
        statsText.fontSize = 24;
        statsText.color = Color.white;
        
        RectTransform statsRect = statsObj.GetComponent<RectTransform>();
        statsRect.anchorMin = Vector2.zero;
        statsRect.anchorMax = Vector2.one;
        statsRect.offsetMin = new Vector2(10, -200);
        statsRect.offsetMax = new Vector2(-10, -50);
        
        // Wire up UI references
        var panelUI = panelObj.GetComponent<HeadshotPanelUI>();
        panelUI.SetReferences(titleText, statsText, panelImage);
        
        Debug.Log("🎨 Headshot Panel UI Created");
    }

    /// <summary>
    /// Auto-create Game Manager
    /// </summary>
    private static void CreateGameManager()
    {
        GameObject managerObj = new GameObject("GameManager");
        DontDestroyOnLoad(managerObj);
        
        GameManager gameManager = managerObj.AddComponent<GameManager>();
        
        // Find and assign references
        HeadshotPanel headshotPanel = FindObjectOfType<HeadshotPanel>();
        HeadshotPanelUI headshotPanelUI = FindObjectOfType<HeadshotPanelUI>();
        
        if (headshotPanel != null && headshotPanelUI != null)
        {
            gameManager.SetReferences(headshotPanel, headshotPanelUI);
            Debug.Log("✅ Game Manager Created and Configured");
        }
    }
}

/// <summary>
/// Extension for HeadshotPanelUI to set references programmatically
/// </summary>
public partial class HeadshotPanelUI : MonoBehaviour
{
    public void SetReferences(TextMeshProUGUI titleText, TextMeshProUGUI statsText, Image panelImage)
    {
        // Will be called from auto-initializer
    }
}

/// <summary>
/// Extension for GameManager to set references programmatically
/// </summary>
public partial class GameManager : MonoBehaviour
{
    public void SetReferences(HeadshotPanel panel, HeadshotPanelUI ui)
    {
        // Will be called from auto-initializer
    }
}
