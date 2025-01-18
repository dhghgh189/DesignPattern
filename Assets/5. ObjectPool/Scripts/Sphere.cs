using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float deactiveTime; 

    private PooledObject poolComponent;

    private void Awake()
    {
        poolComponent = GetComponent<PooledObject>();
    }

    private void OnEnable()
    {
        Invoke(nameof(Deactivate), deactiveTime);
    }

    private void Deactivate()
    {
        if (poolComponent != null)
        {
            poolComponent.ReturnToPool();
            return;
        }

        Destroy(gameObject);
    }
}
