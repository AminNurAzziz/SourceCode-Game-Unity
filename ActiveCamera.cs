using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveCamera : MonoBehaviour
{
    public GameObject dialogBox;
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
