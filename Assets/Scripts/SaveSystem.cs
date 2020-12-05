using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    #region Coins
    public static void SaveCoins1 (CoinSystem coins)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Data1.gdz";
        FileStream stream = new FileStream(path, FileMode.Create);

        CoinsData data = new CoinsData(coins);

        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static CoinsData LoadCoins1 ()
    {
        string path = Application.persistentDataPath + "/Data1.gdz";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            CoinsData data = formatter.Deserialize(stream) as CoinsData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Data1 not found in " + path);
            return null;
        }
    }

    #endregion
    #region Items
    public static void SaveItems (PaymentPanel payment)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Data2.gdz";
        FileStream stream = new FileStream(path, FileMode.Create);

        ItemData data = new ItemData(payment);

        formatter.Serialize(stream, data);
        stream.Close();
    }


    public static ItemData LoadItems ()
    {
        string path = Application.persistentDataPath + "/Data2.gdz";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ItemData data = formatter.Deserialize(stream) as ItemData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Data1 not found in " + path);
            return null;
        }
    }
    #endregion
}
