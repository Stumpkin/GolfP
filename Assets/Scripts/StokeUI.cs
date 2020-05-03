using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StokeUI : MonoBehaviour
{
    public BallControl ball;
    int counter;
    TextMeshProUGUI display;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        display = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        counter = ball.getStrokes();
        display.text = counter.ToString();
    }
}
