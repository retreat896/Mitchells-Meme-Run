using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDamage : MonoBehaviour {

    public int Health;


    // Use this for initialization
    void Start()
    {

        Health = 3;
    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnCollisionEnter2D(Collision2D collision)
    {




        if (Health <= 0)
        {
            levelmanager.DamageTaken();
            Destroy(gameObject);
        }




    }

}

