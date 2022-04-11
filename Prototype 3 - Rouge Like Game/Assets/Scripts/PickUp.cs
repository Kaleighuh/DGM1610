using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public enum PickupType{Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupAmount;
    private Player_Controller playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<Player_Controller>();
    }

    void OnTriggarEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.key = pickupAmount; 
                Debug.Log("You have picked up a Golden Key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins = pickupAmount; 
                Debug.Log("You have picked up" + pickupAmount + "Coins!");
            }
              else if(currentPickup == PickupType.Gem)
            {
                playerController.gems = pickupAmount; 
                Debug.Log("You have picked up" + pickupAmount + "Gems!");
            }
            Destroy(gameObject);
        }
    }
}
