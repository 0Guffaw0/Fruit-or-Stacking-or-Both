using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public GameObject Cake_Stack;

    // Start is called before the first frame update
    void Start()
    {
        //I used the plinko demo as the basis (obviously)
        //I should have just done pong, but I thought my concept was going to be easy to execute
        //get-a-load of this guy cam 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        SpawnCake();
    }

    void Move()
    {
        Vector3 offset = Vector3.zero;

        bool isHoldingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isHoldingRight = Input.GetKey(KeyCode.RightArrow);

        if (isHoldingLeft)
            offset.x -= speed;

        if (isHoldingRight)
            offset.x += speed;

        transform.position += offset * Time.deltaTime;
    }

    void SpawnCake()
    {
        bool doSpawn = Input.GetKeyDown(KeyCode.Space);

        if (doSpawn)
        {
            Instantiate(Cake_Stack, transform.position, Quaternion.identity);
        }
    }
}