using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPanahKanan : MonoBehaviour
{
    public Rigidbody2D theRb;
    public float speed;
    void Start(){

    }

    void Update(){
        theRb.velocity = new Vector2(-1,0)*speed;
    }
}
