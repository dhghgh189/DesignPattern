using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private float deactiveTime; 

    private PooledObject poolComponent;

    private WaitForSeconds waitTime;

    private void Awake()
    {
        poolComponent = GetComponent<PooledObject>();
        waitTime = new WaitForSeconds(deactiveTime);
    }

    private void OnEnable()
    {
        StartCoroutine(DeactivateRoutine());
    }

    private void Deactivate()
    {
        Debug.Log("Deactivate");
        if (poolComponent != null)
        {
            poolComponent.ReturnToPool();
            return;
        }

        Destroy(gameObject);
    }

    IEnumerator DeactivateRoutine()
    {
        yield return waitTime;
        Deactivate();
    }
}
