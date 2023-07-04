using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public float durationOfTheMatch;
    private float time;
    // Start is called before the first frame update
    void Start()
    {  
        time = durationOfTheMatch;
        StartCoroutine(clock());
    }

    IEnumerator clock()
    {
        
        while(time > 0)
        {
            time -= 1;
        }
        print("Terminou");
        yield return new WaitForSeconds(1);

    }

}
