using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSounds : MonoBehaviour
{
    
    public List<AudioClip> weaponsShooting;
    public AudioSource weaponShot;

    public void TocarEfeitoDoTiro()
    {
        int rand = Random.Range(0, weaponsShooting.Count);
        weaponShot.clip = weaponsShooting[rand];
        weaponShot.Play();

    }

}
