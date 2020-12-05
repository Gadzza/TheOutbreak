using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaymentPanel : MonoBehaviour
{
    public bool Item0;
    public bool Item1;
    public bool Item2;

    public TextMeshProUGUI Item1Price;
    public TextMeshProUGUI Item2Price;

    public GameObject CoinSystem;

    // Start is called before the first frame update
    void Start()
    {
        LoadSettings();
        if (Item1)
        {
            Item1Price.text = "Owned";
        }
        if (Item2)
        {
            Item2Price.text = "Owned";
        }
        SetItem0True();
    }

    public void SetItem0True()
    {
        if (Item0 == false)
        {
            Item0 = true;
            SaveItem();
        }
    }
    public void SetItem1True()
    {
        if(Item1 == false)
        {
            if (CoinSystem.GetComponent<CoinSystem>().TryPayment(20))
            {
                Item1 = true;
                Item1Price.text = "Owned";
                SaveItem();
                CoinSystem.GetComponent<CoinSystem>().SaveCoins();
            }
            else
            {
                Debug.Log("Not enough money!");
            }
        }else
        {
            Debug.Log("You already have this");
        }
    }
    public void SetItem2True()
    {
        if(Item2 == false)
        {
            if (CoinSystem.GetComponent<CoinSystem>().TryPayment(35))
            {
                Item2 = true;
                Item2Price.text = "Owned";
                SaveItem();
                CoinSystem.GetComponent<CoinSystem>().SaveCoins();
            }
            else
            {
                Debug.Log("Not enough money!");
            }
        }
        else
        {
            Debug.Log("You already have this");
        }
    }

    public bool VerifyItem1()
    {
        if(Item1)
        {
            return true;
        }else
        {
            return false;
        }
    }
    public bool VerifyItem2()
    {
        if(Item2)
        {
            return true;
        }else
        {
            return false;
        }
    }

    public void SaveItem()
    {
        SaveSystem.SaveItems(this);
    }

    public void LoadSettings()
    {
        ItemData data = SaveSystem.LoadItems();

        Item1 = data.item1;
        Item2 = data.item2;

    }
}
