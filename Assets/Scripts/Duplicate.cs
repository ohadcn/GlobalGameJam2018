using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Utils;
public class Duplicate : MonoBehaviour {

    public GameObject obj;
    public int times = 10;

    public bool colorize = true;
    public Color MaxColor = Color.white;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < times; i++)
        {
            GameObject n = Instantiate(obj);
            if (colorize)
            {
                MaterialPropertyBlock blk = new MaterialPropertyBlock();
                Renderer rend = n.GetComponent<Renderer>();
                rend.GetPropertyBlock(blk);
                blk.SetColor("_Color", new Color(Rangify(MaxColor.r), Rangify(MaxColor.g), Rangify(MaxColor.b)));
                rend.SetPropertyBlock(blk);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
