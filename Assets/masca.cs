using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class masca : MonoBehaviour
{
    public bool Item1;
    public bool Item2;

    private int procentaj;
    public int scadere = 1;
    public TextMeshProUGUI Text;
    private int nextUpdate = 1;
    // Start is called before the first frame update
    void Start()
    {
        LoadSettings();

        if(Item2)
        {
            procentaj = 50;
        }
        else
        {
            if (Item1)
            {
                procentaj = 25;
            }
            else
            {
                procentaj = 15;
            }
        }
    }
    public void LoadSettings()
    {
        ItemData data = SaveSystem.LoadItems();

        Item1 = data.item1;
        Item2 = data.item2;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate)
        {
            //Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 2;
            // Call your fonction
            UpdateEverySecond();
        }

    }

    void UpdateEverySecond()
    { 
        if(procentaj>0)
        {
            Text.text = procentaj + "%";
            procentaj -= scadere;
        }
        if (procentaj <= 0)
        {
            Text.text = "0%";
            procentaj -= scadere;
        }
        if(procentaj <= -5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
