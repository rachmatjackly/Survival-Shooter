using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] itemPrefab;
    public Transform[] spawnPoints;

    public GameObject FactoryMethod(int tag)
    {
        int spawnPointIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
        return FactoryMethod(tag, spawnPointIndex);
    }

    public GameObject FactoryMethod(int tag, int spawnPointIndex)
    {
        GameObject item = Instantiate(itemPrefab[tag], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        return item;
    }
}
