using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public bool isKey; // Check this for the Key object
    public bool isMap; // Check this for the Map object

    // This function runs automatically when the player walks into the "sensor"
    private void OnTriggerEnter(Collider other)
    {
        // Check if the thing that walked into us is tagged "Player"
        if (other.CompareTag("Player"))
        {
            // Find the inventory on that player
            PlayerInventory inv = other.GetComponent<PlayerInventory>();

            if (inv != null)
            {
                if (isKey) inv.hasRed = true;
                if (isMap) inv.hasGreen = true;

                Debug.Log(gameObject.name + " added to inventory!");

                // Make the object disappear from the world
                gameObject.SetActive(false);
            }
        }
    }
}
