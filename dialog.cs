using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialog : MonoBehaviour
{

    public GameObject dialogBox;
    public Text dialogText;
    public string dialogue;
    public bool playerInRange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange){
                dialogBox.SetActive(true);
                if (Input.GetKeyDown(KeyCode.Space )){
                    //Method untuk memanggil / berpindah scene yang kita inginkan
                    SceneManager.LoadScene("diskusi");
                }
                //dialogText.text = dialogue;
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
