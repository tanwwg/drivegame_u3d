using System;
using UnityEngine;
using UnityEngine.Events;

public class OppCar : MonoBehaviour
{
    public UnityEvent onDespawn;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGER " + other.name);
        Destroy(this.gameObject);
        onDespawn.Invoke();
    }
}
