using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemiesSounds : MonoBehaviour
{
    public List<AudioClip> enemiesSounds;
    public AudioSource audioSource;
    private float random;

    private void Start() {
        List<float> timers = new List<float>() {3.130f, 1.30f, 2.130f, 2.223f, 1.45f, 3.125f, 3.25f, 3.5f, 
        3.75f, 1.0f, 1.125f, 1.25f, 1.5f, 1.75f, 2.0f, 2.125f, 2.25f, 2.5f};

        List<int> numbers = new List<int>() {1, 2, 3};

        Random rnd = new Random();
        int randIndex = rnd.Next(numbers.Count);

        if(numbers[randIndex] == 1)
        {
            randIndex = rnd.Next(timers.Count);
            random = timers[randIndex];

            StartCoroutine(Wait(random));
        }
        else
        {
            audioSource.enabled = false;
        }

    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        StartCoroutine(TocarSomDoInimigo());
    }

    IEnumerator TocarSomDoInimigo()
    {
        while(true)
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(enemiesSounds.Count);
            audioSource.clip = enemiesSounds[randIndex];
            audioSource.Play();

            
            yield return new WaitForSeconds(random);
        }

    }
}
