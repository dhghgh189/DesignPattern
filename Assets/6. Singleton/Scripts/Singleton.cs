using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                Init();
            }

            return instance;
        }
    }


    void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private static void Init()
    {
        instance = FindAnyObjectByType<T>();

        if (instance == null)
        {
            GameObject go = new GameObject(typeof(T).Name);
            instance = go.AddComponent<T>();
            DontDestroyOnLoad(go);
        }
    }
}
