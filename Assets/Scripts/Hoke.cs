using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoke : MonoBehaviour
{
    int timer = 0;
    public AudioSource sound;
    bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collider)
    {
        if (!played)
        {
            sound.Play();
            played = true;
        }

        if (timer > 500)
        {
            Destroy(collider.gameObject);
            timer = 0;
            Application.Quit();
        }
        timer++;

    }
}
