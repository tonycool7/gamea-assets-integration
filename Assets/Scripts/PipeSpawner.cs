using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float timer;
    public GameObject pipes;
    public float height = 10f;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.Instance;
        SpawnPipe();
    }

    void SpawnPipe()
    {
        GameObject newpipePrefab = Instantiate(pipes);
        newpipePrefab.transform.position += transform.position + new Vector3(0, Random.Range(-height, height), 0);
        if (gameManager.pointCount == 30) newpipePrefab.transform.GetChild(3).gameObject.SetActive(true);
        Destroy(newpipePrefab, 15);
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = GameManager.Instance;

        print(gameManager.spawnTime);

        if (timer > gameManager.spawnTime)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
