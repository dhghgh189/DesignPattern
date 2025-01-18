using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestShooter : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;

    RaycastHit hit;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!Physics.Raycast(ray, out hit, Mathf.Infinity, (1 << LayerMask.NameToLayer("Ground"))))
        {
            return;
        }

        Sphere sphere = pool.GetFromPool().GetComponent<Sphere>();
        sphere.transform.position = hit.point;
    }
}
