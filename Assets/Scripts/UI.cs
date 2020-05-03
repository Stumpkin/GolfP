using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI : MonoBehaviour
{
    TextMeshProUGUI powerText;
    public BallControl ball;
    int timer;
    // Start is called before the first frame update

    void Start()
    {
        timer = 0;
        powerText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        timer = ball.getPowerTimer();
        powerText.text = timer.ToString();

        if (timer < 1000 && timer > 0)
        {
            powerText.color = Color.green;
        }

        else if (timer >= 1000 && timer < 1700)
        {
            powerText.color = Color.yellow;
        }

        else
        {
            powerText.color = Color.red;
        }
    }
}
