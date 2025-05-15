using UnityEngine;
using UnityEngine.Events;

public class SpriteSelector : MonoBehaviour
{
    public UnityEvent<Sprite> onStart;
    public SpriteTable sprites;

    public void Start()
    {
        onStart.Invoke(sprites.SelectRandom());
    }
}
