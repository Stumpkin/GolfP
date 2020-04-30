using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // force should be in the range of 20 - 2500
    public Rigidbody rb;
    public bool isMoving;
    [SerializeField] int force;
    public GameObject def;
    private int timer = 0;
    private int powerTimer = 0;
    Vector3 lastPosition;
    Vector3 dir;
    

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        lastPosition = transform.position;
        force = 20;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //lastPosition = transform.position;
        var speed = Vector3.Distance(lastPosition, transform.position);
        
        if (isMoving)
        {
            timer++;
            if (timer >= 1800)
            {
                timer = 0;
                lastPosition = transform.position;
                Debug.Log("Timer reset");
            }
        }
       
        if (speed < 5 && timer == 600 && isMoving)
        {
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(Vector3.zero);
            rb.isKinematic = true;
            isMoving = false;
            lastPosition = transform.position;
            timer = 0;
            Debug.Log("Ball should be stopped");
        }

        if(Input.GetKeyDown(KeyCode.Mouse0) && !isMoving)
            //light hit is 20 - 100 / med hit is 110 - 1200 / hard hit is 1200 - 2500
            //if the user does not hit the button at the max it will hit the ball at 20;
        {
            if (powerTimer == 0)
            {
                force = 20;
            }

            force = powerTimer;
            powerTimer = 0;
            rb.isKinematic = false;
            Vector3 direction = transform.position + Camera.main.transform.forward * force;
            dir = direction;
            rb.AddForce(direction);
            Debug.Log("LOL");
            isMoving = true;
        }
        
        Debug.Log(powerTimer);
        if (!isMoving)
        {
            if (powerTimer == 2600)
            {
                powerTimer = 0;
            }
            powerTimer += 10;
        }
    }

    public bool moving()
    {
        return isMoving;
    }

    public int getDirection()
    {
        return force;
    }

    public int getPowerTimer()
    {
        return powerTimer;
    }
}
