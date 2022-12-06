using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sriptOutputMisi2 : MonoBehaviour
{
    Text text;
    public GameObject green1;
    public static int misi2;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = misi2.ToString();
        if(misi2>0){
            green1.SetActive(true);
        }
    }
}
