using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    
    Animator am;
    Player pm;
    SpriteRenderer sr;

    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<Player>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }
}
