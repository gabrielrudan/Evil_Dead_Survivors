using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAnimator : MonoBehaviour
{
    Animator am;
    SerAtraidoPeloPlayer em;
    SpriteRenderer sr;
    Vida vida;
    Movimentar movement;
    DropWeapon drop;

    [SerializeField]
    private SimpleFlash flashEffect;

    void Start()
    {
        am = GetComponent<Animator>();
        em = GetComponent<SerAtraidoPeloPlayer>();
        sr = GetComponent<SpriteRenderer>();
        vida = GetComponent<Vida>();
        flashEffect = GetComponent<SimpleFlash>();
        movement = GetComponent<Movimentar>();
        drop = GetComponent<DropWeapon>();
    }

    void Update()
    {

        if(vida.GetVida() > 0)
        {
            am.SetBool("Morrendo", false);
        }
        else
        {
            am.SetBool("Morrendo", true);
            em.enabled = false;
            movement.MovementInput = Vector2.zero;
            flashEffect.enabled = false;
            if(drop.podeDropar == true)
            {
                if(drop.dropCount == 0)
                {
                    drop.DroparArma();
                    Destroy(gameObject, (float)0.25);
                }
                else
                {
                    Destroy(gameObject, (float)0.25);
                }
            }
            else
            {
                Destroy(gameObject, (float)0.25);
            }
        }
        
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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bala"))
        {
            flashEffect.Flash();
        }
        else if(other.gameObject.CompareTag("Player"))
        {
            am.SetTrigger("Atacando");
        }
    }

}
