using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sriptOutputMisi4 : MonoBehaviour
{
    Text text;
    public GameObject red1;
    public static int misi4;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = misi4.ToString();
        if(misi4<0){
            red1.SetActive(true);
        }
    }
}
