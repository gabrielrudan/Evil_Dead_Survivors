using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostraClock : MonoBehaviour
{
    public Clock clock;
    public TextMeshProUGUI timerText;
    
    // Update is called once per frame
    void Update()
    {
        float[] time = clock.getTime();
        DisplayTime(time);
    }

    void DisplayTime(float[] timeToDisplay)
    {
        timerText.text = string.Format("{0:00}:{1:00}", timeToDisplay[0], timeToDisplay[1]);
    }
}
