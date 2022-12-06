using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakan : MonoBehaviour
{
    public Rigidbody2D theRb;
    public float speed;
    public FloatingJoystick joystick;

    public Animator myAnim;

    void Start(){
        Time.timeScale=1;
    }

    void Update(){
        //theRb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*speed;
        theRb.velocity = new Vector2((joystick.Horizontal), (joystick.Vertical))*speed;
        myAnim.SetFloat("moveX", theRb.velocity.x);
        myAnim.SetFloat("moveY", theRb.velocity.y);
        
        if(joystick.Horizontal == 1 || joystick.Horizontal == -1 || joystick.Vertical == 1 || joystick.Vertical == -1){
            myAnim.SetFloat("lastMoveX",  joystick.Horizontal);
            myAnim.SetFloat("lastMoveY",  joystick.Horizontal);
        }
    }
    
    

}
