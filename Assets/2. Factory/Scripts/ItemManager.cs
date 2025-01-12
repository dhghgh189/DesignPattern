using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private static ItemManager instance;
    public static ItemManager Instnace { get => instance; }

    // 각각의 아이템 팩토리들
    [SerializeField] private ItemFactory[] factories;

    // 각 팩토리를 탐색하기 위한 Dictionary
    private Dictionary<string, ItemFactory> factoryDict = new Dictionary<string, ItemFactory>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        for (int i = 0; i < factories.Length; i++)
        {
            // 각각의 팩토리가 생산하는 아이템명을 키값으로 하여 팩토리들을 저장해둔다.
            factoryDict.Add(factories[i].ItemName, factories[i]);
        }
    }

    // 외부에서 아이템을 생성하기 위해 호출할 메서드
    public Item CreateItem(string itemName, Vector3 pos)
    {
        // itemName에 해당하는 팩토리가 존재하는지 확인
        if (!factoryDict.TryGetValue(itemName, out ItemFactory factory))
            return null;

        return factory.GetProduct(pos) as Item;
    }
}
