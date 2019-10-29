using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMgr : Singleton<ObjectMgr>
{
    #region Public

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public GameObject parent;
        public int size;
    }

    public List<Pool> pools; // Pool class의 개수
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    #endregion

    private void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            // 오브젝트 셋팅
            if (!pool.parent)
            {
                for (int i = 0; i < pool.size; i++)
                {
                    GameObject obj = Instantiate(pool.prefab);
                    obj.SetActive(false);
                    objectPool.Enqueue(obj);
                }
            } else {
                for (int i = 0; i < pool.size; i++)
                {
                    GameObject obj = Instantiate(pool.prefab, pool.parent.transform);
                    obj.SetActive(false);
                    objectPool.Enqueue(obj);
                }
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    // 지정된 위치에 생성된 오브젝트를 켜주는 함수
    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        // Key X
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.Log("Couldn't find it");
            return null;
        }

        // Key O
        GameObject objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}
