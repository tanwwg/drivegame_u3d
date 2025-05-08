using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Vector2 moveSpeed;

    public UnityEvent onCollide;

    public Rigidbody2D body;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        var moveAction = InputSystem.actions.FindAction("Move");  
        var moveValue = moveAction.ReadValue<Vector2>();
        
        body.AddForce(Vector2.Scale(moveValue, moveSpeed));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<MovingEnemy>() == null) return;
        Debug.Log("COLLIDE! " + this.name + " to " + other.gameObject.name);
        onCollide.Invoke();
    }

    public void SetTimeScale(float scale)
    {
        Time.timeScale = scale;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
