using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {


    public int Health;


	// Use this for initialization
	void Start () {

        Health = 3;
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {

        Health--;
        Destroy(gameObject);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
