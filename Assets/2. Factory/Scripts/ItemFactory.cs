using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : Factory
{
    // 생성할 아이템 프리팹
    [SerializeField] private Item prefab;

    // 외부에서 이름으로 탐색하기 위해 getter 제공
    public string ItemName { get => prefab.ProductName; } 

    // Factory의 추상 메서드인 GetProduct 구현
    // ItemFactory는 Item을 생성하고 초기화 한 후 반환한다.
    public override IProduct GetProduct(Vector3 pos)
    {
        Item item = Instantiate(prefab, pos, Quaternion.identity);
        item.Init();
        return item;
    }
}
