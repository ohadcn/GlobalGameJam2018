﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Fruit fruit;

    public AudioClip[] crashsounds;
    public AudioClip endsound;
    public AudioClip[] themes;

    private AudioSource source;

    public string[] names = new string[] { "Banana",
        //"Strawberry",
        "Straw",
        "Orange" };
    // Use this for initialization
    void Start()
    {
        fruit = Fruit.BANANA;

    }
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        HittersScript s = collision.collider.GetComponent<HittersScript>();
        if (s != null)
        {
            source.PlayOneShot(crashsounds[Utils.rand.Next() % 2], 1F);
            if (fruit != s.fruit)
            {
                int prev = (int)fruit;
                fruit = (Fruit)(3 - this.fruit - s.fruit);
                //GetComponent<Animator>().Play(names[prev] + "To" + names[(int)fruit]);
                GetComponent<Animator>().SetTrigger(names[(int)s.fruit] + "HitsMy" + names[prev]);
                
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var s = other.GetComponent<Hole>();
        if (s != null && s.fruit == fruit)
        {
            ScoringManager.score++;
            source.PlayOneShot(endsound,1F);
            FindObjectOfType<Restarter>().Restart();
        }
    }
}