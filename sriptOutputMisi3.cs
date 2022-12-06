using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sriptOutputMisi3 : MonoBehaviour
{
    Text text;
    public GameObject red;
    public static int misi3;
    
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = misi3.ToString();
        if(misi3<0){
            red.SetActive(true);
        }
    }
}
