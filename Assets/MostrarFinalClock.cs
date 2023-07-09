using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarFinalClock : MonoBehaviour
{
    public Clock clock;
    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        float time = clock.getLastTime();
        //print(time);
        DisplayTime(time);
    }

    void DisplayTime(float timeToDisplay)
    {
        float min = Mathf.FloorToInt(timeToDisplay / 60);
        float seg = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", min, seg);
    }
}
