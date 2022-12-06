using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sriptOutputMisi1 : MonoBehaviour
{
    Text text;
    public GameObject green;
    public static int misi1;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = misi1.ToString();
        if(misi1>0){
            green.SetActive(true);
        }
    }
}
