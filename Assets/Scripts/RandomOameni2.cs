using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RandomOameni2 : MonoBehaviour
{
    public GameObject[] SpawnX;
    public int puncte=6;
    public int Ori;
    public GameObject Om1;
    public GameObject Om2;
    public GameObject Om3;
    public GameObject Om4;
    public GameObject Om5;
    public GameObject Om6;
    public GameObject Om7;
    public GameObject Om8;
    public GameObject Om9;
    public GameObject Om10;
    public GameObject Om11;
    public GameObject Om12;
    public GameObject Coins5;


    // Start is called before the first frame update
    void Start()
    {
        puncte = 6;
        SpawnPersoane();

        for (int i = 0; ( i < SpawnX.Length ) && ( i % 2 != 0 ); i++)
        {
            while (SpawnX[i].activeSelf == false)
            {
                DespawnPersoane();
                SpawnPersoane();
            }
        }
        while(SpawnX[0].activeSelf && SpawnX[1].activeSelf || SpawnX[2].activeSelf && SpawnX[3].activeSelf || SpawnX[4].activeSelf && SpawnX[5].activeSelf || SpawnX[6].activeSelf && SpawnX[7].activeSelf || SpawnX[8].activeSelf && SpawnX[9].activeSelf || SpawnX[10].activeSelf && SpawnX[11])
        {
            DespawnPersoane();
            SpawnPersoane();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPersoane()
    {
        int spawnIndex = Random.Range(0, SpawnX.Length);
        int spawnIndex2 = Random.Range(0, SpawnX.Length);
        int spawnIndex3 = Random.Range(0, SpawnX.Length);
        int spawnIndex4 = Random.Range(0, SpawnX.Length);
        int spawnIndex5 = Random.Range(0, SpawnX.Length);
        int spawnIndex6 = Random.Range(0, SpawnX.Length);

        SpawnX[spawnIndex].SetActive(true);
        while (spawnIndex2 == spawnIndex)
        {
            spawnIndex2 = Random.Range(0, SpawnX.Length);
        }
        SpawnX[spawnIndex2].SetActive(true);

        while (spawnIndex3 == spawnIndex || spawnIndex3 == spawnIndex2)
        {
            spawnIndex3 = Random.Range(0, SpawnX.Length);
        }
        SpawnX[spawnIndex3].SetActive(true);

        while (spawnIndex4 == spawnIndex || spawnIndex4 == spawnIndex2 || spawnIndex4 == spawnIndex3)
        {
            spawnIndex4 = Random.Range(0, SpawnX.Length);
        }
        SpawnX[spawnIndex4].SetActive(true);

        while (spawnIndex5 == spawnIndex || spawnIndex5 == spawnIndex2 || spawnIndex5 == spawnIndex3 || spawnIndex5 == spawnIndex4)
        {
            spawnIndex5 = Random.Range(0, SpawnX.Length);
        }
        SpawnX[spawnIndex5].SetActive(true);

        while (spawnIndex6 == spawnIndex || spawnIndex6 == spawnIndex2 || spawnIndex6 == spawnIndex3 || spawnIndex6 == spawnIndex4 || spawnIndex6 == spawnIndex5)
        {
            spawnIndex6 = Random.Range(0, SpawnX.Length);
        }
        SpawnX[spawnIndex6].SetActive(true);
    }

    void DespawnPersoane()
    {
        for (int i = 0; i < SpawnX.Length; i++)
        {
            SpawnX[i].SetActive(false);
        }
    }

   public void OmNormal7()
    {
        Om7.SetActive(false);
       // puncte += 1;
        Ori += 1;
    }
    public void OmNormal8()
    {
        Om8.SetActive(false);
       // puncte += 1;
        Ori += 1;
    }
    public void OmNormal9()
    {
        Om9.SetActive(false);
      //  puncte += 1;
        Ori += 1;
    }
    public void OmNormal10()
    {
        Om10.SetActive(false);
       // puncte += 1;
        Ori += 1;
    }
    public void OmNormal11()
    {
        Om11.SetActive(false);
       // puncte += 1;
        Ori += 1;
    }
    public void OmNormal12()
    {
        Om12.SetActive(false);
       // puncte += 1;
        Ori += 1;
    }
    public void OmNormal1()
    {
        Om1.SetActive(false);
        puncte -= 1;
        Ori += 1;
    }
    public void OmNormal2()
    {
        Om2.SetActive(false);
        puncte -= 1;
        Ori += 1;
    }
    public void OmNormal3()
    {
        Om3.SetActive(false);
        puncte -= 1;
        Ori += 1;
    }
    public void OmNormal4()
    {
        Om4.SetActive(false);
        puncte -= 1;
        Ori += 1;
    }
    public void OmNormal5()
    {
        Om5.SetActive(false);
        puncte -= 1;
        Ori += 1;
    }
    public void OmNormal6()
    {
        Om6.SetActive(false);
       puncte -= 1;
        Ori += 1;
    }

    public void Pleaca()
    {
        if (puncte >= 4)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(2);
        }
        if (puncte >= 2 && puncte < 4)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(1);
        }
        if (puncte >= 0 && puncte < 2)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(0);
        }
        SceneManager.LoadScene("Map");
    }
}
