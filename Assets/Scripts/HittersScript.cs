using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class HittersScript : MonoBehaviour
{
    public Fruit fruit;
    public Sprite[] sprites;

    static int ty = 0;

    string[] imnames = { "banana", "strawberry", "orange" };
    // Use this for initialization
    void Start()
    {
        fruit = (Fruit)(ty % 3);    
        GetComponent<SpriteRenderer>().sprite = sprites[ty%3];
       // Debug.Log("", GetComponent<SpriteRenderer>().sprite);
        ty++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
