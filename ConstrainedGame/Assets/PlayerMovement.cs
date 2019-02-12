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
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<Rigidbody>().AddForce(Vector3.down * dropSpeed);

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

    public void takeP1Input()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            this.GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S");
            //this.transform.position += Vector3.up * Time.deltaTime * 2 * dropSpeed;
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
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
