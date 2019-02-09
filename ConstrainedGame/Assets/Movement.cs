using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

    void Start()
    {
        float x = Random.Range(40, 50f);
        float y = Random.Range(40, 50f);
        float z = Random.Range(40, 50f);
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(speed * x, speed * y, speed * z);
    }

    // Update is called once per frame
    void Update () {
        //this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }

    void OnCollisionEnter(Collision col)
    {
        
    }
}
