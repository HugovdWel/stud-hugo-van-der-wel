using UnityEngine;

public class EnemySpawnerController : MonoBehaviour
{
    public GameObject enemy;
    public float spawnHeight;
    public int timeBetweenEnemySpawns;

    private float _timeOfLastSpawn;

    private void Start()
    {
        _timeOfLastSpawn = 0;
    }

    private void Update()
    {
        if (!(Time.time - timeBetweenEnemySpawns >= _timeOfLastSpawn)) return;

        _timeOfLastSpawn = Time.time;
        Instantiate(enemy, position: (transform.position + new Vector3(0, spawnHeight, 0)), Quaternion.identity);
    }
}