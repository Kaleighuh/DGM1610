using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public enum PickupType{health};
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;

    [Header("Health")]

    private int curHP;
    private int maxHP;
    public int heal;
    public float healRange;
   
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.health)
            {
                playerController.health = pickupAmount; 
                Debug.Log("You have picked up a some health!");
            }
            
            Destroy(gameObject);
        }
    }

    void Heal(int heal)
    {
        curHP += heal;
    }
}
