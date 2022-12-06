using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptMisi1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        sriptOutputMisi1.misi1= 0 ;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            // Do something  
            Destroy(gameObject);
            sriptOutputMisi1.misi1 = 50;
        }  
    }
}
