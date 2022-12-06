using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculinPanah : MonoBehaviour
{
    public GameObject panah;
    public float posisiMaximal, possisiMinimal;
    public float waktuMaximal, waktuMinimal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculPanah());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MunculPanah(){
        Instantiate(panah, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(MunculPanah());
    }
}
