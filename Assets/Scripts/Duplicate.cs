using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Utils;
public class Duplicate : MonoBehaviour {

    public GameObject obj;
    public int times = 10;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < times; i++)
        {
            Instantiate(obj);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
