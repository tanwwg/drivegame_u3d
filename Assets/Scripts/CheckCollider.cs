using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    public Collider2D checkCollider;
    public LayerMask checkLayers;

    public bool IsOverlap()
    {
        return checkCollider.IsTouchingLayers(checkLayers.value);
    }
}
