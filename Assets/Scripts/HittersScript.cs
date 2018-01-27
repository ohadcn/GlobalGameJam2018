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
    bool startmode = true;
    int  startcounter = 0;
    bool destroymod = false;
    int destroycounter = 0;
    int AnimFrames = 20;
    float desiredScale = (float)0.9;
    string[] imnames = { "banana", "strawberry", "orange" };
    // Use this for initialization
    void Start()
    {
        fruit = (Fruit)(ty % 3);    
        GetComponent<SpriteRenderer>().sprite = sprites[ty%3];
       // Debug.Log("", GetComponent<SpriteRenderer>().sprite);
        ty++;
        startmode = true;
    }

    // Update is called once per frame
    void Update()
    {

        if ((startmode) && (startcounter < AnimFrames))
        {
            startcounter++;
            float scale = (float)Math.Pow((double)(desiredScale), (double)(AnimFrames- startcounter));
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            if (startmode)
            {
                startcounter = 0;
                startmode = false;
                transform.localScale = new Vector3((float)1.0, (float)1.0, (float)1.0);
            }

        }






        if ((destroymod) && (destroycounter < AnimFrames))
        {
            destroycounter++;
            float scale = (float)Math.Pow((double)desiredScale, (double)destroycounter);
            transform.localScale = new Vector3(scale, scale, scale);
        }
        else
        {
            if (destroymod)
            {
                destroycounter = 0;
                destroymod = false;
                transform.localScale = new Vector3((float)1.0, (float)1.0, (float)1.0);
                StartingSpeed ss = GetComponent<StartingSpeed>();               
                ss.Start();
                //Start();
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        var t = collision.collider.tag;
        if (t == "Player")
            destroymod = true;
    }
}
