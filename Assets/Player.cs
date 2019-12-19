using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    BoxCollider2D[] colliders;
    GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.Find("Goal");
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0,0);
        if (Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKey(KeyCode.LeftArrow))
        {
            vel += new Vector3(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            vel += new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow))
        {
            vel += new Vector3(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            vel += new Vector3(0, -1);
        }
        vel = vel.normalized *5;
        rb.velocity = vel;
    }
}
