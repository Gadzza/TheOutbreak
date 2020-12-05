using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RandomPeople : MonoBehaviour
{

    public GameObject[] SpawnX;
    public TextMeshProUGUI grade2;
    public int timer;
    float Grade;
    public int puncte;
    public int Ori;
    public Button Buton;
    public Button Buton1;
    public Button Buton2;
    public GameObject Coins5;
    private static int coins;
    public void LoadCoins()
    {
        CoinsData data = SaveSystem.LoadCoins1();

        coins = data.coins;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnX.Length; i++)
        {
            SpawnX[i].SetActive(false);
        }

        SpawnRandomX();
        LoadCoins();
    }

    void Update()
    {
        if (Ori>=3)
        {
            Buton.interactable = true;
        }else
        {
            Buton.interactable = false;
        }
    }

    IEnumerator Wait(int timp)
    {
        
        for (int i = 0; i < SpawnX.Length; i++)
        {
            SpawnX[i].SetActive(false);
        }
        grade2.text = "°C";
        Buton1.interactable = false;
        Buton2.interactable = false;

        yield return new WaitForSecondsRealtime(timp);

        Buton1.interactable = true;
        Buton2.interactable = true;

        SpawnRandomX();
    }
    void SpawnRandomX()
    {
        int spawnIndex = Random.Range(0, SpawnX.Length);

        SpawnX[spawnIndex].SetActive(true);

        Grade = Random.Range(35, 39);
        grade2.text = Grade + "°C";
    }

    public void TrimiteAcasa()
    {
        if (Grade<=37)
        {
            puncte -= 1;
            Ori += 1;
            StartCoroutine(Wait(3));
        }
        else
        {
            puncte += 1;
            Ori += 1;
            StartCoroutine(Wait(3));
        }
    }

    public void LasaSaIntre()
    {
        if (Grade <= 37)
        {
            puncte += 1;
            Ori += 1;
            StartCoroutine(Wait(3));
        }
        else
        {
            puncte -= 1;
            Ori += 1;
            StartCoroutine(Wait(3));
        }
    }

    public void GoHome()
    {
        if (puncte>=5)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(2);
        }
        if(puncte >= 3 && puncte < 5)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(1);
        }
        if(puncte >= 0 && puncte < 3)
        {
            Coins5.GetComponent<CoinSystem>().AddCoins(0);
        }
        SceneManager.LoadScene("Map");
    }

}
