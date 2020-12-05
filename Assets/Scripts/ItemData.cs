using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public bool item1;
    public bool item2;

    public ItemData (PaymentPanel payment)
    {
        item1 = payment.VerifyItem1();
        item2 = payment.VerifyItem2();
    }

}

