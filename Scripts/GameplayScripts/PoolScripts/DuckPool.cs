using UnityEngine;

public class DuckPool : MonoBehaviour
{
    [SerializeField] private GameObject duckPrefab;
    [SerializeField] private int poolSize = 6;
    [SerializeField] private float spawnTime = 1f;

    private GameObject[] duck;
    private int obstacleCount;
    private float timeElapsed;
    void Start()
    {
        duck = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            duck[i] = Instantiate(duckPrefab);
            duck[i].SetActive(false);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnDuck();
        }
    }
    private void SpawnDuck()
    {
        timeElapsed = 0f;

        Vector3 spawnPosition = new Vector3(-9, -0.5f, 0);
        duck[obstacleCount].transform.position = spawnPosition;

        if (!duck[obstacleCount].activeSelf)
        {
            duck[obstacleCount].SetActive(true);
        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}
