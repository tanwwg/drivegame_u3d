using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingEnemy : MonoBehaviour
{
    public CheckCollider leftCheck;
    public CheckCollider rightCheck;

    public Vector2 speed;
    
    public Rigidbody2D body;

    private void Start()
    {
        body.linearVelocityX = Random.Range(0, 2) == 0 ? speed.x : -speed.x;
        body.linearVelocityY = speed.y;
    }

    private void FixedUpdate()
    {
        if (leftCheck.IsOverlap())
        {
            body.linearVelocityX = speed.x;
        }  
        else if (rightCheck.IsOverlap())
        {
            body.linearVelocityX = -speed.x;
        }
    }
}
