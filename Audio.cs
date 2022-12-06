using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    [SerializeField] Image SoundOn;
    [SerializeField] Image SoundOff;
    private bool muted = false;

    public void OnButtoPress(){
        if(muted==false){
            muted= true;
            AudioListener.pause = true;
        }
        else{
            muted = false;
            AudioListener.pause = false;
        }
        Save();  
        UpdateButtonIcon();
    }

    private void UpdateButtonIcon(){
        if(muted==false){
            SoundOn.enabled = true;
            SoundOff.enabled = false;
        }
        else{
            SoundOn.enabled = false;
            SoundOff.enabled = true;
        }
    }

    private void Load(){
        muted = PlayerPrefs.GetInt("muted")==1;
    }

    private void Save(){
        PlayerPrefs.SetInt("muted", muted? 1:0);
    }

    // Start is called before the first frame update
    void Start()
    {
        musik.Destroy(gameObject);
        if(!PlayerPrefs.HasKey("muted")){
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }else{
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause=muted;
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}
