using System;
using UnityEngine;
using UnityEngine.Events;

public class TimeSlow : MonoBehaviour
{
    public float slowTimeScale;
    public float slowTimeDuration;

    public UnityEvent onTimeSlow;
    public UnityEvent onTimeRestore;    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        var iscar = other.GetComponent<GameController>() != null;
        if (!iscar) return;

        Time.timeScale = slowTimeScale;
        onTimeSlow.Invoke();
        this.Invoke(nameof(RestoreTime), slowTimeDuration);
    }

    void RestoreTime()
    {
        Time.timeScale = 1.0f;
        onTimeRestore.Invoke();
    }
}
