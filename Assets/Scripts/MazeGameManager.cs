using UnityEngine;
using TMPro; 

public class MazeGameManager : MonoBehaviour
{
    [SerializeField] private float currentHealth = 100f;
    [SerializeField] private TextMeshProUGUI healthDisplay;

    void Update()
    {
        // Simple health drain to create urgency in the maze
        if (currentHealth > 0)
        {
            currentHealth -= Time.deltaTime * 1.5f;
            UpdateUI();
        }
    }

    // It will be triggered by your Chest Event
    public void AddHealth(float bonus)
    {
        currentHealth = Mathf.Clamp(currentHealth + bonus, 0, 100);
        UpdateUI();
        Debug.Log("Health increased via Event-Driven System.");
    }

    private void UpdateUI()
    {
        if (healthDisplay != null)
        {
            healthDisplay.text = "HP: " + Mathf.CeilToInt(currentHealth);
        }
    }
}
