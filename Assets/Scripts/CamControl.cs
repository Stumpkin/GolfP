using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public Transform Target;
    [SerializeField] Vector3 Pos;
    [SerializeField] Vector3 orginalRot;
    [SerializeField] Vector3 rot;
    private Vector3 lastPos;
    //Rigidbody rb;
    public BallControl ball;
    public float camSpeed = 8f;


    // Start is called before the first frame update
    void Start()
    {
        Pos = new Vector3(Target.position.x - .4f, Target.position.y + 3, Target.position.z - 6);
        orginalRot = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //Pos = updatePos(Pos, Target);
        transform.position = Pos;
       
        
        if (ball.moving())
        {
            //Pos = new Vector3(Target.position.x - .4f, Target.position.y + 3, Target.position.z - 6);
            //Pos = transform.position;
            //rb.AddForce(transform.position * ball.getDirection());
            // transform.eulerAngles = rot;
            transform.eulerAngles = orginalRot;
        }

        //Debug.Log(Target.position);
        //Debug.Log(transform.position);
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (Input.GetAxis("Mouse X") > 0)
            {
                transform.RotateAround(Target.position, Vector3.up, camSpeed);
                rot = transform.eulerAngles;
                Pos = transform.position;
            }

            else if (Input.GetAxis("Mouse X") < 0)
            {
                transform.RotateAround(Target.position, Vector3.down, camSpeed);
                rot = transform.eulerAngles;
                Pos = transform.position;
            }

            //transform.LookAt(Target);
        }
    }

    Vector3 updatePos(Vector3 p, Transform tar)
    {
        return new Vector3(p.x + tar.position.x, tar.position.y, p.z + tar.position.z);
    }
}

