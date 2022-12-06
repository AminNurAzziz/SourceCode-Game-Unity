using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scripOutputBintang : MonoBehaviour
{
    Text text;
    public GameObject bintang1;
    public GameObject bintang2;
    public GameObject bintang3;
    public static int bintang;

    void Start()
    {
        text = GetComponent<Text>();
        bintang = totalPoin.totalP;
    }

    void Update()
    {
        text.text = bintang.ToString();
        if(bintang<50 && bintang >0){
            bintang1.SetActive(true);
        }else if(bintang>50 && bintang<100){
            bintang1.SetActive(true);
            bintang2.SetActive(true);
        }else if(bintang==100){
            bintang1.SetActive(true);
            bintang2.SetActive(true);
            bintang3.SetActive(true);
        }
    }
}

