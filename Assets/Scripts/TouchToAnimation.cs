using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchToAnimation : MonoBehaviour {

    public AnimationClip anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetMouseButtonDown(0) || Input.touchCount > 0))
        {
            //GetComponent<Animator>().Play(anim.name, 1);
        }
    }
}
