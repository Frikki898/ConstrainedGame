using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallMovement : MonoBehaviour {

    public float speed;
    private Rigidbody rigid;

    void Start()
    {
        Debug.Log("ASDF");
        float x = Random.Range(10, 30);
        float y = Random.Range(10, 30);
        float z = Random.Range(10, 30);
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(this.GetComponent<Rigidbody>().velocity.magnitude);
    }

    public void LateUpdate()
    {
        rigid.velocity = speed * rigid.velocity.normalized;
    }

    void OnCollisionEnter(Collision col)
    {

        //Debug.Log(col.gameObject.name);   
    }

    private void OnCollisionExit(Collision collision)
    {
        // if the forward movement of the ball is too slow (on the z axis), the game will become too slow
        // so we increase the z vector a bit
        if (System.Math.Abs(rigid.velocity.z/speed) < 0.5f)
        {
            rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y, rigid.velocity.z + 0.1f * speed);
        } 
        // We do this so the ball will never stick to the wall, therefore we push him out of it.
        if (collision.gameObject.tag == "LeftWall")
        {
            Debug.Log("LeftWall");
            if (System.Math.Abs(rigid.velocity.x/speed) < 0.1)
            {
                rigid.velocity = new Vector3(rigid.velocity.x + 0.1f, rigid.velocity.y, rigid.velocity.z);
            }
        }
        else if (collision.gameObject.tag == "RightWall")
        {
            Debug.Log("RightWall");
            if (System.Math.Abs(rigid.velocity.x / speed) < 0.1)
            {
                rigid.velocity = new Vector3(rigid.velocity.x - 0.1f, rigid.velocity.y, rigid.velocity.z);
            }
        }
        else if (collision.gameObject.tag == "UpperWall")
        {
            Debug.Log("UpperWall");
            if (System.Math.Abs(rigid.velocity.y / speed) < 0.1)
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y - 0.1f, rigid.velocity.z);
            }
        }
        else if (collision.gameObject.tag == "DownWall")
        {
            Debug.Log("DownWall");
            if (System.Math.Abs(rigid.velocity.y / speed) < 0.1)
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y + 0.1f, rigid.velocity.z);
            }
        }

        if (System.Math.Abs(rigid.velocity.x / speed) < 0.05f)
        {
            if (rigid.velocity.x < 0)
            {
                rigid.velocity = new Vector3(rigid.velocity.x - 0.1f, rigid.velocity.y, rigid.velocity.z);
            }
            else
            {
                rigid.velocity = new Vector3(rigid.velocity.x + 0.1f, rigid.velocity.y, rigid.velocity.z);
            }
        }
        if (System.Math.Abs(rigid.velocity.y / speed) < 0.05f)
        {
            if (rigid.velocity.y < 0)
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y - 0.1f, rigid.velocity.z);
            }
            else
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y + 0.1f, rigid.velocity.z);
            }
        }
    }

}
