using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 direction = new Vector3(0, 0, 5);
            rb.AddForce(direction);
            Debug.Log("LOL");
        }
        
    }
}
