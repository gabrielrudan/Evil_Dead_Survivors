using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSounds : MonoBehaviour
{
    public List<AudioClip> damageSounds;
    public AudioSource audioPlayer;
    public AudioClip deathSound;

    public void TocarDamageSound()
    {
        int rand = Random.Range(0, damageSounds.Count);
        audioPlayer.clip = damageSounds[rand];
        audioPlayer.Play();

    }

    public void TocarDeathSound()
    {
        audioPlayer.clip = deathSound;
        audioPlayer.Play();
    }
}
