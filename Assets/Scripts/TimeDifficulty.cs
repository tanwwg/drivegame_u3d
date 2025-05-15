using System.Linq;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DifficultyItem
{
    public float elapsedTime;
    public UnityEvent onSpawn;
    public bool spawned { get; set; }
}

public class TimeDifficulty : MonoBehaviour
{
    public ElapsedTime et;

    public DifficultyItem[] items;

    // Update is called once per frame
    void Update()
    {
        foreach (var d in items)
        {
            if (et.elapsed > d.elapsedTime && !d.spawned)
            {
                d.spawned = true;
                d.onSpawn.Invoke();
            }
        }
    }
}
