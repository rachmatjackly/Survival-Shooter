using UnityEngine;

public class EnemyFactory : MonoBehaviour, IFactory
{
    [SerializeField]
    public GameObject[] enemyPrefab;
    public Transform[] spawnPoints;

    public GameObject FactoryMethod(int tag)
    {
        int spawnPointIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
        return FactoryMethod(tag, spawnPointIndex);
    }

    public GameObject FactoryMethod(int tag, int spawnPointIndex)
    {
        GameObject enemy = Instantiate(enemyPrefab[tag], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        return enemy;
    }
}
