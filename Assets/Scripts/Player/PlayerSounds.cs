using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    

    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    private AudioSource walkSoundEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {

        if(rb.velocity.x != 0 || rb.velocity.y != 0)
        {
            if(!walkSoundEffect.isPlaying)
            {
                walkSoundEffect.Play();
            }
        }
        else
        {
            walkSoundEffect.Stop();
        }
        
    }
}
