using UnityEngine;
using UnityEngine.Events;

public class ElapsedTime : MonoBehaviour
{
    public UnityEvent<string> onElapsedTime;

    // Update is called once per frame
    void Update()
    {
        onElapsedTime.Invoke(((int)(Time.time)).ToString());
    }
}
