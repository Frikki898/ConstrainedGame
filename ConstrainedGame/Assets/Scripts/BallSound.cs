using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour {
    private AudioSource ballAudio;
	// Use this for initialization
	void Start () {
        ballAudio = GetComponent<AudioSource>();
	}
    private void OnCollisionEnter(Collision collision)
    {
        ballAudio.Play();
    }
}
