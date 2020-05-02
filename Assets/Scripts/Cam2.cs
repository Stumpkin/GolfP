using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2 : MonoBehaviour
{
    public Transform Target;
    public BallControl ball;
    [SerializeField] Vector3 offSet;
    [SerializeField] Vector3 rot;
    [SerializeField] Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        offSet = new Vector3(Target.position.x - .2f, Target.position.y + .5f, Target.position.z + 3);
        //temp = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.position + offSet;

        if (Input.GetKey(KeyCode.Mouse1))
        {
            offSet = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 8f, Vector3.up) * offSet;
            transform.LookAt(Target.transform);
        }

           
    }
}
