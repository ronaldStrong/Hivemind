using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Seeker : MonoBehaviour
{
    GameObject player;
    int gameXMax;
    int gameYMax;
    Rigidbody2D rb;
    Rigidbody2D playerrb;
    // Start is called before the first frame update
    void Start()
    {
        gameXMax = Screen.width;
        gameYMax = Screen.height;
        player = GameObject.Find("Player");
        playerrb = player.GetComponent<Rigidbody2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //PLACEHOLDER FOR PATH FINDING
        Vector2 force = playerrb.position - rb.position;
        rb.AddForce(force);
    }
}
