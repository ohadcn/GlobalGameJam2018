using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittersScript : MonoBehaviour
{
    public Fruit fruit;

    static int ty = 0;
    // Use this for initialization
    void Start()
    {
        fruit = (Fruit)(ty % 3);
        ty++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
