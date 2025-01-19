using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [SerializeField] private int minHp = 0;
    [SerializeField] private int maxHp = 100;
    private int currentHp;

    public int MinHp => minHp;
    public int MaxHp => maxHp;
    public int CurrentHp 
    { 
        get { return currentHp; } 
        set 
        { 
            currentHp = value;
            currentHp = Mathf.Clamp(currentHp, minHp, maxHp);

            OnChangedHp?.Invoke();
        } 
    }

    public event Action OnChangedHp;

    private void Awake()
    {
        Clear();
    }

    public void Clear()
    {
        CurrentHp = maxHp;
    }
}
