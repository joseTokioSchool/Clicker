using UnityEngine;

public class Duck2Pool : MonoBehaviour
{
    [SerializeField] private GameObject duck2Prefab;
    [SerializeField] private int poolSize = 6;
    [SerializeField] private float spawnTime = 0.75f;

    private GameObject[] duck2;
    private int obstacleCount;
    private float timeElapsed;
    void Start()
    {
        duck2 = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            duck2[i] = Instantiate(duck2Prefab);
            duck2[i].SetActive(false);
        }
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawnTime)
        {
            SpawnDuck2();
        }
    }
    private void SpawnDuck2()
    {
        timeElapsed = 0f;

        Vector3 spawnPosition = new Vector3(-9, -1.5f, 0);
        duck2[obstacleCount].transform.position = spawnPosition;

        if (!duck2[obstacleCount].activeSelf)
        {
            duck2[obstacleCount].SetActive(true);
        }

        obstacleCount++;

        if (obstacleCount == poolSize)
        {
            obstacleCount = 0;
        }

    }
}
