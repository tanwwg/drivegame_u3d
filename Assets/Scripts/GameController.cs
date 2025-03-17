using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    public Vector2 moveSpeed;

    public UnityEvent onCollide;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        var moveAction = InputSystem.actions.FindAction("Move");  
        var moveValue = moveAction.ReadValue<Vector2>();
        this.GetComponent<Rigidbody2D>().linearVelocity = Vector2.Scale(moveValue, moveSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("COLLIDE! " + this.name + " to " + other.gameObject.name);
        onCollide.Invoke();
    }

}
