using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   
    // Start is called before the first frame update
    
    // Update is called once per frame
    void OnTiggerEnter(Collision col)
    {
        Debug.Log("Something entered me OwO");
        Destroy(col.gameObject);
    }

    void OnColisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
    }
}
