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
    private int stokes = 0;
    Vector3 lastPosition;
    Vector3 beforeHit;
    Vector3 dir;
    public AudioSource sound;
    

    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        lastPosition = transform.position;
        beforeHit = transform.position;
        force = 20;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //lastPosition = transform.position;
        var speed = Vector3.Distance(lastPosition, transform.position);
        Debug.Log(speed);
        if (isMoving)
        {
            timer += 2;
            if (timer >= 1200)
            {
                timer = 0;
                lastPosition = transform.position;
                //Debug.Log("Timer reset");
            }
        }
       
        if (speed < 20 && timer == 600 && isMoving)
        {
            rb.velocity = new Vector3(0, 0, 0);
            rb.AddForce(Vector3.zero);
            rb.isKinematic = true;
            isMoving = false;
            lastPosition = transform.position;
            timer = 0;
            //Debug.Log("Ball should be stopped");
        }

        if(Input.GetKeyDown(KeyCode.Mouse0) && !isMoving)
            //light hit is 20 - 100 / med hit is 110 - 1200 / hard hit is 1200 - 2500
            //if the user does not hit the button at the max it will hit the ball at 20;
        {
            beforeHit = transform.position;
            sound.Play();
            if (powerTimer <= 100)
            {
                force = 20;
            }

            force = powerTimer;
            powerTimer = 0;
            rb.isKinematic = false;
            Vector3 direction = transform.position + Camera.main.transform.forward * force;
            dir = direction;
            rb.AddForce(direction);
            stokes++;
            isMoving = true;
        }
        
        //Debug.Log(powerTimer);
        if (!isMoving)
        {
            if (powerTimer == 2600)
            {
                powerTimer = 0;
            }
            powerTimer += 2;
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

    public int getStrokes()
    {
        return stokes;
    }

    public void Reset()
    {
        isMoving = false;
        rb.isKinematic = true;
        transform.position = beforeHit;
    }
}
