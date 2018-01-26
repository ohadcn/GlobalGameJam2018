using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedSpeed : MonoBehaviour {

    public Vector3 minSpeed = Vector3.zero;
    public Vector3 maxSpeed = Vector3.one * 1000;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit(Collision collision)
    {

    }
}
