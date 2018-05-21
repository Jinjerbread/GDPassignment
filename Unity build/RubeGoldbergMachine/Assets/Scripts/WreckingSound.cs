using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingSound : MonoBehaviour {

    public AudioSource tickSource;

	// Use this for initialization
	void Start () {

        tickSource = GetComponent<AudioSource>();
            
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WreckingBall")
        {
            tickSource.Play();
        }

    }
    
        
    }


