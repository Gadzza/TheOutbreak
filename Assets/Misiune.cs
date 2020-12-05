using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Misiune : MonoBehaviour
{
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Desc;
    int RandomNumber;
    void Start()
    {
        RefreshNumber();
        MisiuneRandom();
    }
    void Update()
    {
        MisiuneRandom();
    }

    public void MisiuneRandom()
    {
        if (RandomNumber > 50)
        {
            Title.text = "Thermometer";
            Desc.text = "Go and help the shop keeper with your thermometer!";
        }else
        {
            if (RandomNumber < 50)
            {
                Title.text = "Safety Measures";
                Desc.text = "Highlight the people without masks in order to prevent the spread of the virus";
            }
        }
    }

    public void RefreshNumber()
    {
         RandomNumber = Random.Range(0, 100);
    }
}
