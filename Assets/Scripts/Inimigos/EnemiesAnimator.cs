using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAnimator : MonoBehaviour
{
    Animator am;
    SerAtraidoPeloPlayer em;
    SpriteRenderer sr;

    void Start()
    {
        am = GetComponent<Animator>();
        em = GetComponent<SerAtraidoPeloPlayer>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if(em.movementInput.x == 0 && em.movementInput.y == 0)
        {
            am.SetBool("Andando", false);

            if(em.movementInput.x > 0 && em.movementInput.y == 0) //right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(em.movementInput.x < 0 && em.movementInput.y == 0) //left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x == 0 && em.movementInput.y > 0) //up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x == 0 && em.movementInput.y < 0) //down
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(em.movementInput.x > 0 && em.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x > 0 && em.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(em.movementInput.x < 0 && em.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x < 0 && em.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoParaCima", false);
            }

        }

        else
        {
            am.SetBool("Andando", true);

            SpriteDirectChecker();

            if(em.movementInput.x > 0 && em.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x > 0 && em.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(em.movementInput.x < 0 && em.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(em.movementInput.x < 0 && em.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoParaCima", false);
            }
        }

    }

    void SpriteDirectChecker()
    {
        if(em.movementInput.x < 0) //flipa
        {
            sr.flipX = true;
        }
        else //nao flipa
        {
            sr.flipX = false;
        }
    }

}
