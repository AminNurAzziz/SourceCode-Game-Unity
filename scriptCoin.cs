using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptCoin : MonoBehaviour
{
    
    public AudioSource suaraCoin;
    
    void Start()
    {
        totalCoin.coinAmount=0;    
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            suaraCoin.Play();
            // Do something  
            Destroy(gameObject);
            totalCoin.coinAmount++;
        }  
    }

}
