using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class PlayerScript : MonoBehaviour
    {
        public Fruit fruit;
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
            if(s != null)
            {
                Debug.Log("collider, player.property");                
                Debug.Log(s.fruit);
                Debug.Log(fruit);


            if (fruit!= s.fruit)
                    fruit = (Fruit)(3 -this.fruit - s.fruit);
            Debug.Log("after collision");
            Debug.Log(this.fruit);
        }
        }
    }