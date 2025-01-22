using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnInterval = 2f;
    public float maxSpawnInterval = 5f;
    [Header("References")]
    public GameObject[] gameObjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        int randomIndex = Random.Range(0, gameObjects.Length);
        Instantiate(gameObjects[randomIndex], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnInterval, maxSpawnInterval));
    }
}
