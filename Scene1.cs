using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{
    public static Scene1 scene1;
    public TMP_InputField inputField;
    
    public string player_name;
    
    private void Awake(){
        if(scene1==null){
            scene1 = this;
            DontDestroyOnLoad(gameObject);

        }else{
            Destroy(gameObject);
        }
    }
    
    public void SetPlayerName(){
        player_name = inputField.text;
        //SceneManager.LoadScene("slide_fiks");
         LoadToScene("slide_fiks");
    }
    
    public void LoadToScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
