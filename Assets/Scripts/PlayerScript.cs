using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public Fruit fruit;
    public string[] names = new string[] { "Banana",
        //"Strawberry",
        "Straw",
        "Orange" };
    // Use this for initialization
    void Start()
    {
        fruit = Fruit.BANANA;
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
            if (fruit != s.fruit)
            {
                int prev = (int)fruit;
                fruit = (Fruit)(3 - this.fruit - s.fruit);
                //GetComponent<Animator>().Play(names[prev] + "To" + names[(int)fruit]);
                GetComponent<Animator>().SetTrigger(names[(int)s.fruit] + "HitsMy" + names[prev]);
            }
        }
    }
}