using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalPoin : MonoBehaviour
{
    Text text;
    public static int totalP;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        totalP = sriptOutputMisi1.misi1 + sriptOutputMisi2.misi2 + sriptOutputMisi3.misi3+sriptOutputMisi4.misi4;
    }

    // Update is called once per frame
    void Update()
    {
       text.text = totalP.ToString();
    }
}
