using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform Target;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, 30f * Time.deltaTime);
        transform.LookAt(Target);
    }
}
