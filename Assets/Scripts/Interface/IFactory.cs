using UnityEngine;

public interface IFactory
{
    GameObject FactoryMethod(int tag);
    GameObject FactoryMethod(int tag, int spawnPointIndex);
}