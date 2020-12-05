using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomX : MonoBehaviour
{

    public GameObject[] SpawnX;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnX.Length; i++)
        {
            SpawnX[i].SetActive(false);
        }
        SpawnRandomX();
    }

    void SpawnRandomX()
    {
        int RandomNumber = Random.Range(0, 100);
        if (RandomNumber <= 75)
        {
            int spawnIndex = Random.Range(0, SpawnX.Length);
            int spawnIndex2 = Random.Range(0, SpawnX.Length);

            while (spawnIndex2 == spawnIndex)
            {
                spawnIndex2 = Random.Range(0, SpawnX.Length);
            }

            SpawnX[spawnIndex].SetActive(true);
            SpawnX[spawnIndex2].SetActive(true);
        }
        else
        {
            int spawnIndex = Random.Range(0, SpawnX.Length);
            int spawnIndex2 = Random.Range(0, SpawnX.Length);
            int spawnIndex3 = Random.Range(0, SpawnX.Length);

            while (spawnIndex2 == spawnIndex || spawnIndex2 == spawnIndex3)
            {
                spawnIndex2 = Random.Range(0, SpawnX.Length);
            }
            while (spawnIndex3 == spawnIndex || spawnIndex3 == spawnIndex2)
            {
                spawnIndex3 = Random.Range(0, SpawnX.Length);
            }

            SpawnX[spawnIndex].SetActive(true);
            SpawnX[spawnIndex2].SetActive(true);
            SpawnX[spawnIndex3].SetActive(true);
        }

    }
}
