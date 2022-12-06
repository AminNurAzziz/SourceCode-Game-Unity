using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakanKeyboard : MonoBehaviour
{
    public Rigidbody2D theRb;
    public float speed;

    public Animator myAnim;

    void Start(){
        Time.timeScale=1;
    }

    void Update(){
        theRb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*speed;
        
        myAnim.SetFloat("moveX", theRb.velocity.x);
        myAnim.SetFloat("moveY", theRb.velocity.y);
        
        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1){
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
    
    

}
