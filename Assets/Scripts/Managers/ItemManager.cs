using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public float spawnTime = 3f;

    internal List<GameObject> spawnedItems = new List<GameObject>();

    [SerializeField]
    MonoBehaviour factory;
    ItemFactory Factory { get { return factory as ItemFactory; } }

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        //Memduplikasi item
        try
        {
            if (playerHealth.currentHealth > 0)
            {
                int spawnPoint = Random.Range(0, Factory.spawnPoints.Length);
                int spawnItem = Random.Range(0, Factory.itemPrefab.Length);
                if (!spawnedItems.Exists(
                    (item) => item.transform.position == Factory.spawnPoints[spawnPoint].position
                    ))
                {
                    spawnedItems.Add(Factory.FactoryMethod(spawnItem, spawnPoint));
                }
            }
        }
        catch (System.Exception)
        { }
    }
}
