using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ground : MonoBehaviour {



    public bool floor;




	// Use this for initialization
	void Start () {
        floor = true;

	}



    public void Shot()
    {

     

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        floor = true;

    }


    // Update is called once per frame
    void Update () {
		
	}
}
