using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private PooledObject prefab;
    [SerializeField] private uint initPoolSize; 

    private Stack<PooledObject> _pool = new Stack<PooledObject>();

    private void Awake()
    {
        InitPool();
    }

    private void InitPool()
    {
        PooledObject go;

        for (int i = 0; i < initPoolSize; i++)
        {
            go = Instantiate(prefab);
            ReturnToPool(go);
        }
    }

    public PooledObject GetFromPool()
    {
        PooledObject go;

        if (_pool.Count <= 0)
        {
            go = Instantiate(prefab);
            return go;
        }

        go = _pool.Pop();
        go.gameObject.SetActive(true);

        return go;
    }

    public void ReturnToPool(PooledObject go)
    {
        go.gameObject.SetActive(false);
        _pool.Push(go);
    }
}
