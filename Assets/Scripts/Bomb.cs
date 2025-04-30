using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    public UnityEvent onBomb;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var iscar = other.GetComponent<GameController>() != null;
        if (!iscar) return;

        var enemies = FindObjectsByType<MovingEnemy>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
        foreach(var e in enemies) Destroy(e.gameObject);
        onBomb.Invoke();
    }

}
