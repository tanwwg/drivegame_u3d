using System;
using UnityEngine;
using UnityEngine.Events;

public class Sparks : MonoBehaviour
{
    public Collider2D wall;
    public UnityEvent onCollide;
    public UnityEvent onExitCollide;    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider == wall)
        {
            onCollide.Invoke();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider == wall)
        {
            onExitCollide.Invoke();
        }
    }
}
