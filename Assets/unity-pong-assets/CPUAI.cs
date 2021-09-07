using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUAI : MonoBehaviour
{
    public float speed = 5.0f;
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
        var ballLoc = GameObject.Find("Ball").transform.position;
        var pos = transform.position;
        if (ballLoc.y > pos.y)
        {
            vel.y = speed;
        }
        else
        {
            vel.y = -speed;
        }

        rd2b.velocity = vel;
        
        if (pos.y > boundY)
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
