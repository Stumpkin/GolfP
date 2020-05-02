using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoke : MonoBehaviour
{
    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Something hit me XI");
    }

    void OnTriggerStay(Collider collider)
    {
        Debug.Log("Something entered me OwO");
        if (timer > 500)
        {
            Destroy(collider.gameObject);
            timer = 0;
        }
        timer++;

    }
}
