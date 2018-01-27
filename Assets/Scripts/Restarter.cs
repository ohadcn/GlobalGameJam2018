using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour {

    public MonoBehaviour[] ScriptsToReset;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Restart()
    {
        foreach (MonoBehaviour obj in FindObjectsOfType<StartingSpeed>())
            obj.Invoke("Start", 0);
        foreach (MonoBehaviour obj in FindObjectsOfType<Hole>())
            obj.Invoke("Start", 0);

    }
}
