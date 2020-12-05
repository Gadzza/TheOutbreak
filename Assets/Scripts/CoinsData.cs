using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CoinsData
{
    public int coins;

    public CoinsData (CoinSystem coins2)
    {
        coins = coins2.GetCoins();
    }

}
