using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private uint initPoolSize; 

    private Stack<GameObject> _pool = new Stack<GameObject>();

    private void Awake()
    {
        InitPool();
    }

    public void InitPool()
    {
        GameObject go;

        for (int i = 0; i < initPoolSize; i++)
        {
            go = Instantiate(prefab);
            ReturnToPool(go);
        }
    }

    public GameObject GetFromPool()
    {
        GameObject go;

        if (_pool.Count <= 0)
        {
            go = Instantiate(prefab);
            return go;
        }

        go = _pool.Pop();
        go.SetActive(true);

        return go;
    }

    public void ReturnToPool(GameObject go)
    {
        go.SetActive(false);
        _pool.Push(go);
    }
}
