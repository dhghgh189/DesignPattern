using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] private Presenter presenter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            presenter?.TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            presenter?.Heal(10);
        }
    }
}
