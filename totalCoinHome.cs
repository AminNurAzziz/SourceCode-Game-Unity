using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalCoinHome : MonoBehaviour
{
    Text text;

    public static int coin;

    void Start()
    {
        text = GetComponent<Text>();
        coin = totalCoinAkhir.total;
    }

    void Update()
    {
        text.text = coin.ToString();
    }
}
