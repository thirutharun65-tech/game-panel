using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [SerializeField] private HeadshotPanel headshotPanel;
    [SerializeField] private HeadshotPanelUI headshotPanelUI;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        if (headshotPanel != null)
            headshotPanel.OpenPanel();
    }

    public void OnPlayerHeadshot()
    {
        if (headshotPanel != null)
        {
            headshotPanel.AddHeadshot();
            
            if (headshotPanelUI != null)
                headshotPanelUI.UpdateStats(
                    headshotPanel.GetHeadshotCount(),
                    headshotPanel.GetTotalKills()
                );
        }
    }

    public void OnPlayerKill()
    {
        if (headshotPanel != null)
        {
            headshotPanel.AddKill();
            
            if (headshotPanelUI != null)
                headshotPanelUI.UpdateStats(
                    headshotPanel.GetHeadshotCount(),
                    headshotPanel.GetTotalKills()
                );
        }
    }

    public void ResetStats()
    {
        if (headshotPanel != null)
            headshotPanel.ResetStats();
    }
}
