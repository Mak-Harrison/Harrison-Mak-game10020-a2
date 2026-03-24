using UnityEngine;
using UnityEngine.Events; // Essential for UnityEvents


public class TreasureChest : MonoBehaviour, IInteractable
{
    // If this is public, it will show up in the Inspector
    public UnityEvent onChestOpened;

    public void Interact()
    {
        Debug.Log("Success! The interface works.");
        onChestOpened?.Invoke();

        // This makes the chest disappear
        gameObject.SetActive(false);
    }
}
