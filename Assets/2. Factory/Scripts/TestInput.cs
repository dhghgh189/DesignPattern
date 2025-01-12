using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ItemManager.Instance.CreateItem("빨간 포션", new Vector3(-1, 1, 0));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ItemManager.Instance.CreateItem("파란 포션", new Vector3(1, 1, 0));
        }
    }
}
