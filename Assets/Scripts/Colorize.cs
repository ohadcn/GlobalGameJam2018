using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Utils;
public class Colorize : MonoBehaviour {
    public Color MaxColor = Color.white;

    // Use this for initialization
    void Start () {
        MaterialPropertyBlock blk = new MaterialPropertyBlock();
        Renderer rend = GetComponent<Renderer>();
        rend.GetPropertyBlock(blk);
        blk.SetColor("_Color", new Color(Rangify(MaxColor.r), Rangify(MaxColor.g), Rangify(MaxColor.b)));
        rend.SetPropertyBlock(blk);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
