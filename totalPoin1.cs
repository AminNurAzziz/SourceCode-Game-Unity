using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class totalPoin1 : MonoBehaviour
{
    Text text1;

    public static int totalP1;

    void Start()
    {
        text1 = GetComponent<Text>();
        totalP1 =totalPoin.totalP;
    }

    void Update()
    {   
        
        text1.text = totalP1.ToString();
    }
}
