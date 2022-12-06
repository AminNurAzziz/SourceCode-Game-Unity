using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class startMenuu : MonoBehaviour
{
    public void LoadToScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
