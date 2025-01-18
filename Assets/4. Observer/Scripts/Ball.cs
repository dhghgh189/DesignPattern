using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IObserver
{
    [SerializeField] private Subject subject;

    [SerializeField] private Color baseColor;
    [SerializeField] private Color changeColor;

    private Material material;

    private void Awake()
    {
        subject.AddListener(this);

        material = GetComponent<Renderer>().material;
    }

    public void Notify()
    {
        material.color = (material.color == baseColor) ? changeColor : baseColor;
    }

    private void OnDestroy()
    {
        subject.RemoveListener(this);
    }
}
