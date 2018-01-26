using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Utils;
public class StartingSpeed : MonoBehaviour {
    public bool UseRandom = false;
    public Vector3 Speed = Vector3.zero;
    public Vector3 MaxRandomSpeed = Vector3.one;

	// Use this for initialization
	void Start () {
        if (UseRandom)
            Speed = new Vector3(Rangify(MaxRandomSpeed.x),
                Rangify(MaxRandomSpeed.y),
                Rangify(MaxRandomSpeed.z));
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody != null)
            rigidbody.velocity = Speed;
        else
            Debug.Log("no rigid body" + name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
