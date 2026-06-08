using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    float spawnRate = 2f;
    float nextSpawnTime = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void SpawnMeteor()
    {
        float xPos = Random.Range(-3f, 3f);
        Vector3 spawnPos = new Vector3(xPos, transform.position.y, 0f);
        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        nextSpawnTime += Time.deltaTime;
        if(nextSpawnTime >= spawnRate)
        {
            SpawnMeteor();
            nextSpawnTime = 0f;
        }
    }
}
