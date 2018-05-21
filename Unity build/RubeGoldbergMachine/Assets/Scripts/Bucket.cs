using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucket : MonoBehaviour {

    public Transform BucketLift;
    public float speed;
    public Vector3 endposition;
        private bool StartSequence = false;

 private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "LaunchBall")
        {
            StartSequence = true;
        }
    }
	
	// Update is called once per frame
	private void Update () {
		
        float step = speed * Time.deltaTime;

    if (StartSequence == true) 
        {
            BucketLift.transform.position = Vector3.MoveTowards(BucketLift.transform.position, endposition, step);

        }
	}
}
