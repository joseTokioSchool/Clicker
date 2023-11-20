using UnityEngine;

public class DianaPool : MonoBehaviour //Y = 2
{
    [SerializeField] private GameObject dianaPrefab;
    [SerializeField] private int poolSize = 4;
    [SerializeField] private float spawnTime = 1.5f;

    private GameObject[] diana;
    private int obstacleCount;
    private float timeElapsed;
    void Start()
    {
        diana = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            diana[i] = Instantiate(dianaPrefab);
            diana[i].SetActive(false);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnDiana();
        }
    }
    private void SpawnDiana()
    {
        timeElapsed = 0f;

        Vector3 spawnPosition = new Vector3(-9, 2f, 0);
        diana[obstacleCount].transform.position = spawnPosition;

        if (!diana[obstacleCount].activeSelf)
        {
            diana[obstacleCount].SetActive(true);
        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}
