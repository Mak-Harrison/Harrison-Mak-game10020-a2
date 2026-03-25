using UnityEngine;
using UnityEngine.Events; // Essential for UnityEvents



public class TreasureChest : MonoBehaviour, IInteractable
{
    // This makes the event show up in the Inspector
    public UnityEvent onChestOpened;

    public void Interact()
    {
        Debug.Log("Chest Opened!");

            // Trigger the UI/Health update
            onChestOpened?.Invoke();

            // Make the chest disappear
            gameObject.SetActive(false);
    }
}