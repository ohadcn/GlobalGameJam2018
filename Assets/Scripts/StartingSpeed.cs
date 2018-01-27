using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Utils;
public class StartingSpeed : MonoBehaviour {
    public bool UseRandomSpeed = false;
    public Vector3 Speed = Vector3.zero;
    public Vector3 MaxRandomSpeed = Vector3.one;

    public bool UseRandomPos = true;
    public Vector3 Pos = Vector3.zero;
    public Vector3 MaxRandomPos = Vector3.one * 4;

    // Use this for initialization
    public void Start () {
        if (UseRandomSpeed)
            Speed = new Vector3(Rangify(MaxRandomSpeed.x),
                Rangify(MaxRandomSpeed.y),
                Rangify(MaxRandomSpeed.z));
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        if (rigidbody != null)
            rigidbody.velocity = Speed;
        else
            Debug.Log("no rigid body" + name);

        if (UseRandomPos)
            Speed = new Vector3(Rangify(MaxRandomPos.x),
                Rangify(MaxRandomPos.y),
                Rangify(MaxRandomPos.z));
        transform.position = Speed;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
