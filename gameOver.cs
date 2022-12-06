using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{   
    void Start(){
        kalah.g= 0 ;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("panah"))
        {
            Debug.Log ("Collided");
            Time.timeScale=0;
            Destroy(gameObject);
            kalah.g = 10;
            sriptOutputMisi1.misi1=0;
            sriptOutputMisi2.misi2=0;
            sriptOutputMisi3.misi3=0;
            totalCoin.coinAmount=0;
            
        }
    }
}
