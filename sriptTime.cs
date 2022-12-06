using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sriptTime : MonoBehaviour
{
    public Text TextTimer;
    public float waktu=15;
    public bool gameAktif=true;
    public GameObject popupKalah;
    void SetText(){
        float Menit =  waktu/60;
        float Detik =  waktu%60;
        TextTimer.text= Menit.ToString("00" + ":" + Detik.ToString("00"));
    }

    float s;
    private void Update()
    {
        if(gameAktif){
            s += Time.deltaTime;
            if(s>=1){
                waktu--;
                s=0;
            }
            SetText();
        }
        if(gameAktif && waktu<=0){
           // Debug.Log("Game Kalah");
           Destroy (GameObject.FindWithTag("Player"));
            Time.timeScale=0;
            popupKalah.SetActive(true);
            totalCoin.coinAmount=0;
            gameAktif=false;
        }

    }
}
