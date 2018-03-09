using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelmanager : MonoBehaviour
{



    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);


    }

    public static void DamageTaken()
    {
        Application.LoadLevel("Lose");
   
    }



    public void QuitGame()
    {

        Application.Quit();

    }
}

