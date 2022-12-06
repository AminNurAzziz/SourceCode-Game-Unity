using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class totalCoinAkhir : MonoBehaviour
{
    Text text1;

    public static int total;

    void Start()
    {
        text1 = GetComponent<Text>();
        total = total+totalCoin.coinAmount;
    }

    void Update()
    {   
        
        text1.text = total.ToString();
    }
}
