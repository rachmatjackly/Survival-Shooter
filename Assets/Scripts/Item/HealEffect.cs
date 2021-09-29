using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealEffect : MonoBehaviour
{
    public int healAmount = 15;
    GameObject player;
    PlayerHealth playerHealth;
    public ItemManager itemManager;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        itemManager = GameObject.Find("ItemManager").GetComponent<ItemManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && other.isTrigger == false)
        {
            if (itemManager.spawnedItems.Remove(this.gameObject))
            {
                playerHealth.Heal(healAmount);
                Destroy(this.gameObject);
            }
        }
    }
}
