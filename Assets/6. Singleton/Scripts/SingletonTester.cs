using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.StartGame();
    }
}
