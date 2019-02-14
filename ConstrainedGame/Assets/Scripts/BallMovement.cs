using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallMovement : MonoBehaviour {

    public float startSpeed;
    public float speed;
    public float speedUp;
    private Rigidbody rigid;
    public ScoreController scoreController;
    bool hasStartedMoving;

    void Start()
    {
        hasStartedMoving = false;
        speed = startSpeed;
        rigid = GetComponent<Rigidbody>();
        initBall();
    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(this.GetComponent<Rigidbody>().velocity.magnitude);
    }



    public void initBall()
    {
        hasStartedMoving = false;
        transform.position = new Vector3(0, 0, 0);
        rigid.velocity = Vector3.zero;
        speed = startSpeed;
        StartCoroutine(Halt());
        //Random rand = new Random();
        
    }

    public void LateUpdate()
    {
        rigid.velocity = speed * rigid.velocity.normalized;
        speed += speedUp * Time.deltaTime;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "p2Goal")
        {
            scoreController.player2Score += 1;
            CrossSceneRegistry.PlayerTwoScore = scoreController.player2Score;
            initBall();
        }
        else if(col.gameObject.name == "p1Goal")
        {
            scoreController.player1Score += 1;
            CrossSceneRegistry.PlayerOneScore = scoreController.player1Score;
            initBall();
        }
    }

    IEnumerator Halt()
    {
        
        Debug.Log(Time.time);
        yield return new WaitForSeconds(1);
        float x = Random.Range(40, 80);
        float y = Random.Range(40, 80);
        float z = Random.Range(0, 3);
        hasStartedMoving = true;

        Debug.Log("x" + x);
        Debug.Log("y" + y);
        Debug.Log("z" + z);

        if (z > 1)
        {
            rigid.velocity = new Vector3(x, -y, 100);
        }
        else
        {
            rigid.velocity = new Vector3(-x, y, -100);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!hasStartedMoving)
        {
            return;
        }

        if (System.Math.Abs(rigid.velocity.z / speed) < 0.3f)
        {
            if (rigid.velocity.z < 0)
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y, rigid.velocity.z - 0.1f * speed);
            }
            else
            {
                rigid.velocity = new Vector3(rigid.velocity.x, rigid.velocity.y, rigid.velocity.z + 0.1f * speed);
            }
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
