using System;
using UnityEngine;
using UnityEngine.Events;

public class InvokeDelay : MonoBehaviour
{
    public float delay;
    public UnityEvent onInvoke;

    private void Start()
    {
        this.Invoke(nameof(InvokeEvents), delay);
    }

    void InvokeEvents()
    {
        onInvoke.Invoke();
    }
}
