using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(0, 0, ball.transform.position.z);
    }
}
