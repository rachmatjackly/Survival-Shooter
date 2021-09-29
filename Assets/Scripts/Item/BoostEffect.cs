using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostEffect : MonoBehaviour
{
    public float boostAmount = 6f;
    public float duration = 5f;
    GameObject player;
    PlayerMovement playerMovement;
    public ItemManager itemManager;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();
        itemManager = GameObject.Find("ItemManager").GetComponent<ItemManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && other.isTrigger == false)
        {
            if (itemManager.spawnedItems.Remove(this.gameObject))
            {
                playerMovement.Boost(boostAmount, duration);
                Destroy(this.gameObject);
            }
        }
    }
}
