using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinStateTrigger : MonoBehaviour
{
    public bool OnTriggerStay = false;
    public float timer = 0f;
    Collider Win_Rec;

    //I;m a fool in man's shoes. I'm leaving the code in like the statue of Ozymandias. I think I literally need to do like, 
    //a code learning re-haul because I cannot figure this out!
    
    //It's meant to be like, if you cake stack can stay within the pink "win trigger zone" for a certain amount of time, you win!

    void OnTriggerEnter(Collider Win_Rec)
    {
        if (CompareTag("Cake_Stack"))
        {
            OnTriggerStay = true;
        }
    }

    void OnTriggerExit(Collider Win_Rec)
    {
        if (CompareTag("Cake_Stack"))
        {
            OnTriggerStay = false;
            timer = 0f;
        }
    }

    void Update()
    {
        if (OnTriggerStay)
        {
            OnTriggerStay = true;
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                ActivateWinState();
            }
        }
    }

    void ActivateWinState()
    {
      //I made a little screen and everything! 

        SceneManager.LoadScene("Win State Screen");
        

    }
}