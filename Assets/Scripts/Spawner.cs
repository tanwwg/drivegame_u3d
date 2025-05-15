using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;

    public Collider2D box;

    public float startTime = 0.0f;
    public float spawnEvery = 3.0f;

    public float lifetime = 3.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnNew", startTime, spawnEvery);
    }

    private void OnDisable()
    {
        this.CancelInvoke();
    }

    public void SpawnNew()
    {
        var bounds = box.bounds;
        var spawnPos = GetRandomPosition(bounds.min, bounds.max);

        var newSpawn = Instantiate(spawn);
        newSpawn.transform.position = spawnPos;
        newSpawn.SetActive(true);
        
        Destroy(newSpawn, lifetime);
    }

    Vector3 GetRandomPosition(Vector3 minBounds, Vector3 maxBounds)
    {
        var x = Random.Range(minBounds.x, maxBounds.x);
        var y = Random.Range(minBounds.y, maxBounds.y);
    
        return new Vector3(x, y, 0);
    }
    
}
