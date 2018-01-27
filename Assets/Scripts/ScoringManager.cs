using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringManager : MonoBehaviour {

    public static int score = 0;
    public GUIStyle style;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        Rect rect = new Rect(0, 0, w, h * 2 / 30);
        style.fontSize = (int)rect.height;
        string text = GameController.seconds.ToString() + "\tScore: " + score;
        GUI.Label(rect, text, style);

    }
}
