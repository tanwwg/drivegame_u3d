using UnityEngine;

public class RoadScroller : MonoBehaviour
{
    public Vector2 delta;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<MeshRenderer>().material.SetTextureOffset("_MainTex", Time.time * delta);
    }
}
