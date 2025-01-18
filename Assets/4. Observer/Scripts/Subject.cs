using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Subject : MonoBehaviour, IPointerClickHandler
{
    private List<IObserver> observers = new List<IObserver>();

    public void AddListener(IObserver observer)
    {
        observers.Add(observer);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Notify();
    }

    public void RemoveListener(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Notify();
        }
    }
}
