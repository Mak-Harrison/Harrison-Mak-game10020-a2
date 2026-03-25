using UnityEngine;
using UnityEngine.Events; // Essential for UnityEvents



public class TreasureChest : MonoBehaviour, IInteractable
{
    // This makes the event show up in the Inspector
    public UnityEvent onChestOpened;

    public void Interact()
    {
        // Find the inventory component on the player
        PlayerInventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();

        if (inventory != null && inventory.HasRequiredItems())
        {
            Debug.Log("Inventory Check Passed! Firing Event...");
            onChestOpened?.Invoke(); // THE EVENT FIRES HERE 
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Event Blocked: You need the Key and the Map!");
    }
    }
}