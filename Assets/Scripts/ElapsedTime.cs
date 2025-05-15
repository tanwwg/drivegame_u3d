using UnityEngine;
using UnityEngine.Events;

public class ElapsedTime : MonoBehaviour
{
    public float elapsed;
    public UnityEvent<string> onElapsedTime;

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        onElapsedTime.Invoke(((int)(elapsed)).ToString());
    }
}
