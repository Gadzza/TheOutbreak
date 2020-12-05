using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI self;
    private static int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadCoins();
    }

    // Update is called once per frame
    void Update()
    {
        self.text = "Money: " + coins;
    }

    public void AddCoins(int coins2)
    {
        coins = coins + coins2;
        SaveCoins();
    }

    public bool TryPayment(int price)
    {
        if(CoinSystem.coins >= price)
        {
            CoinSystem.coins = CoinSystem.coins - price;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AddCoinsButton()
    {
        AddCoins(1);
    }

    public int GetCoins()
    {
        return coins;
    }

    public void SaveCoins()
    {
        SaveSystem.SaveCoins1(this);
    }

    public void LoadCoins ()
    {
        CoinsData data = SaveSystem.LoadCoins1();

        coins = data.coins;
    }
}
