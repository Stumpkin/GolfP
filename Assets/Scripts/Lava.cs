using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    int timer;
    public BallControl ball;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log(timer);
        timer++;

        if (timer >= 30)
        {
            ball.Reset();
        }
    }
}
