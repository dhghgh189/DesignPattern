using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IProduct
{
    [SerializeField] private string itemName;

    // IProduct의 getter 구현
    public string ProductName => itemName;

    // IProduct의 Init 구현
    public void Init()
    {
        Debug.Log($"아이템 초기화 : {itemName}");
    }
}
