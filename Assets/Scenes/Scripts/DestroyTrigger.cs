using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    //I've tried a coupld of different methods with this. I feel like it's haunted. 
    //It just ain't working! I just wanted to clean up the cake pieces!

    private void OnTriggerEnter2D(Collider2D cakeDestroyer) => Destroy(GetComponent<Cake_Stack>().gameObject);
}