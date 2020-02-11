using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInitializer : MonoBehaviour
{
    public SOEnemy enemyType;

    GameObject modelHolder;
    public string poolTag;

    Vector3 position;
    Quaternion rotation;

    public void Init()
    {
        poolTag = enemyType.enemyType.ToString();
        Debug.Log(poolTag);

        position = transform.position;

        rotation = transform.rotation;

        SpawnEnemy(poolTag, position, rotation);
    }

    void SpawnEnemy(string tag, Vector3 pos, Quaternion rot)
    {
        EnemyPooler.Instance.SpawnFromPool(tag, pos, rot);
    }
}
