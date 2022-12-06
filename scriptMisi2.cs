using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptMisi2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sriptOutputMisi2.misi2= 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // Do something  
            Destroy(gameObject);
            sriptOutputMisi2.misi2= 50;
        }  
    }
}
