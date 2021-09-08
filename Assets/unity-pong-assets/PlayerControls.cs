using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rd2b;

    // Start is called before the first frame update
    void Start()
    {
        rd2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rd2b.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        } 
        else if(Input.GetKey(moveDown)) 
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }

        rd2b.velocity = vel;

        var pos = transform.position;
        if(pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }

        transform.position = pos;
    }
}
