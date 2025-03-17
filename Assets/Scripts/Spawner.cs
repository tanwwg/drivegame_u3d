using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;

    public Collider2D box;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnNew();
    }

    public void SpawnNew()
    {
        var bounds = box.bounds;
        var spawnPos = GetRandomPosition(bounds.min, bounds.max);

        var newSpawn = Instantiate(spawn);
        newSpawn.transform.position = spawnPos;
        newSpawn.SetActive(true);
    }

    Vector3 GetRandomPosition(Vector3 minBounds, Vector3 maxBounds)
    {
        var x = Random.Range(minBounds.x, maxBounds.x);
        var y = Random.Range(minBounds.y, maxBounds.y);
    
        return new Vector3(x, y, 0);
    }
    
}
