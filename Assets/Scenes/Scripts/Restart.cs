using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Update()
    {   
        // Resets game on a "r" press...or at least it WOULD if it WORKED! I tried to just have it like...reset the scene?
        //I thought normal debugging was a pain - it's way worse when there aren't any error messages to at least guide your fumbling!

        if (Input.GetKeyDown("r"))
        {
            Time.timeScale = 1f;

            Retry();
        }

        //it mocks me. 
        void Retry()
        {

           SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

    }
}

