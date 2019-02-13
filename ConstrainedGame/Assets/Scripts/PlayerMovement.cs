using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    public bool isP1;
    public float speed;
    public float dropSpeed;
    public float jumpForce;
    private Rigidbody rigid;
    private bool goingLeft;
    private bool goingRight;
    private bool goingUp;
    

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
        goingLeft = false;
        goingRight = false;
        goingUp = false;
    }

    // Update is called once per frame
    void Update () {
        

        if(isP1)
        {
            takeP1Input();
            //cam1.transform.position = this.transform.position + new Vector3(0, 0, -10);              
        }
        else
        {
            takeP2Input();
            //cam2.transform.position = this.transform.position + new Vector3(0, 0, 10);
        }

        
    }

    // addForce should be in FixedUpdate()
    private void FixedUpdate()
    {
        rigid.AddForce(Vector3.down * dropSpeed);

        if (goingLeft)
        {
            goingLeft = false;
            rigid.AddForce(Vector3.left * speed);
        }
        if (goingRight)
        {
            goingRight = false;
            rigid.AddForce(Vector3.right * speed);
        }
        if (goingUp)
        {
            goingUp = false;
            //makes it so the jump will always make the paddle jump as much even if it's falling down
            rigid.velocity = new Vector3(rigid.velocity.x, 0, rigid.velocity.z);
            rigid.AddForce(Vector3.up * jumpForce);
        }
    }

    public void takeP1Input()
    {
        if(Input.GetKey(KeyCode.A))
        {
            goingLeft = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            goingRight = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            goingUp = true;
        }
    }

    public void takeP2Input()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(this.gameObject.name);
    }
}
