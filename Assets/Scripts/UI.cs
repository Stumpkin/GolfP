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
    }
}
