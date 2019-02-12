using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    public float speed;

    void Start()
    {
        Debug.Log("ASDF");
        float x = Random.Range(10, 30);
        float y = Random.Range(10, 30);
        float z = Random.Range(10, 30);
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,1);
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(this.GetComponent<Rigidbody>().velocity.magnitude);
    }

    public void LateUpdate()
    {
        this.GetComponent<Rigidbody>().velocity = speed * this.GetComponent<Rigidbody>().velocity.normalized;
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);   
    }
}
