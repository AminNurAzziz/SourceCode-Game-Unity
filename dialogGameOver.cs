using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogGameOver : MonoBehaviour
{
    public GameObject dialogBox;
    public Text dialogText;
    public string dialogue;
    public bool playerInRange;
    public bool gameAktif=true;
    public GameObject popupKalah;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange){
                //dialogBox.SetActive(true);
                Time.timeScale=0;
                gameAktif=false;
                popupKalah.SetActive(true);
        }else{
            if(dialogBox.activeInHierarchy){
                dialogBox.SetActive(false);
            }
        }

    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerInRange=true;
        } 
    }

    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerInRange=false;
            dialogBox.SetActive(false);
        }
    }
}

