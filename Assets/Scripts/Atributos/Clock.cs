using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public static Clock Instance;

    public static float lastTime;
    private float timeValue;
    private float min;
    private float seg;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        timeValue = 0;
    }

    private void Update()
    {
        timeValue += Time.deltaTime;
        min = Mathf.FloorToInt(timeValue / 60);
        seg = Mathf.FloorToInt(timeValue % 60);
        //float tempoAux = timeValue;
        lastTime = timeValue;
    }

    public float[] getTime()
    {
        float[] tempo = new float[2];
        tempo[0] = min; 
        tempo[1] = seg;
        return tempo;
    }

    public void turnTimeToZero()
    {
        timeValue = 0;
    }
    public float getLastTime()
    {
        return lastTime;
    }
}
