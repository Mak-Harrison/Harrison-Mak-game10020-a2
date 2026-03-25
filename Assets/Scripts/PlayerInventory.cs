using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasRed = false;
    public bool hasGreen = false;

    // A helper method the chest can call to check status
    public bool HasRequiredItems()
    {
        return hasRed && hasGreen;
    }
}