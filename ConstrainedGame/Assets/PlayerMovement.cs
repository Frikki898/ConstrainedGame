using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Camera cam1;
    public Camera cam2;
    public bool isP1;
    public float speed;
	
	// Update is called once per frame
	void Update () {
        
        if(isP1)
        {
            takeP1Input();
            cam1.transform.position = this.transform.position + new Vector3(0, 0, -10);                
        }
        else
        {
            takeP2Input();
            cam2.transform.position = this.transform.position + new Vector3(0, 0, 10);
        }

        
    }

    public void takeP1Input()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            //Todo
        }
    }

    public void takeP2Input()
    {

    }
}
