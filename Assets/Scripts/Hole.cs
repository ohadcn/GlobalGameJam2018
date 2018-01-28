using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {
    public Fruit fruit;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    // Use this for initialization
    void Start () {
        int r = Utils.rand.Next();
        fruit = (Fruit)(r % 3);
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[r % 3];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
