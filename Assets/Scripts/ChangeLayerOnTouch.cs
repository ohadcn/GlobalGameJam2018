using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayerOnTouch : MonoBehaviour {

    public LayerMask DefaultLayer;
    public LayerMask OnTouchLayer;


    private int OnTouch, NoTouch;
	// Use this for initialization
	void Start () {
        OnTouch = (int)Mathf.Log(OnTouchLayer.value, 2);
        NoTouch = (int)Mathf.Log(DefaultLayer.value, 2);
    }

    // Update is called once per frame
    void Update () {
        if (gameObject.layer != OnTouchLayer.value && 
            (Input.GetMouseButtonDown(0) || Input.touchCount > 0))
        {
            gameObject.layer = OnTouch;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.layer = NoTouch;
    }
}
