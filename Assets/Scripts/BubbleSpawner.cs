using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float xRange = 8.0f;
    public float spawnInterval = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnBubble", 0.0f, spawnInterval);
    }

    public void SpawnBubble()
    {
        float xPos = Random.Range(-xRange, xRange);
        Vector3 spawnPos = new Vector3(xPos, -6.0f, 0.0f);
        Instantiate(bubblePrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
