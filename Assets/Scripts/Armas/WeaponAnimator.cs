using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimator : MonoBehaviour
{
    Animator am;
    Player pm;
    SpriteRenderer sr;
    WeaponManager wp;
    Animator pam;

    [SerializeField]
    public GameObject weaponPrefab;

    [SerializeField]
    private Transform PaiBala;

    void Start()
    {
        am = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        pm = weaponPrefab.transform.parent.transform.parent.gameObject.GetComponent<Player>();
        wp = weaponPrefab.transform.parent.transform.parent.gameObject.GetComponent<WeaponManager>();
        pam = weaponPrefab.transform.parent.transform.parent.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        am.SetBool("ArmaPega", true);

        // ---------------- MUDANDO A POSICAO DO PAI BALA DEPENDENDO DA ARMA ----------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ------------------------------------ > PISTOLA < ---------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Pistola")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                        
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                        
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                        
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                        
                }
            }
                else
                {
                    if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                    {
                        
                    }
                    else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                    {
                        
                    }
                    else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                    {
                        
                    }
                    else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                    {
                        
                    }
                }
        }

        // ----------------------------------------------------------------------------------------------------

        if(pm.movementInput.x == 0 && pm.movementInput.y == 0)
        {

            if(pm.movementInput.x > 0 && pm.movementInput.y == 0) //right
            {
                am.SetBool("OlhandoPraCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y == 0) //left
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x == 0 && pm.movementInput.y > 0) //up
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x == 0 && pm.movementInput.y < 0) //down
            {
                am.SetBool("OlhandoPraCima", false);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoPraCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoPraCima", false);
            }

        }
        else
        {

            SpriteDirectChecker();

            if(pm.movementInput.x > 0 && pm.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoPraCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoPraCima", true);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoPraCima", false);
            }
        }
    }

    void SpriteDirectChecker()
    {
        if(pm.movementInput.x < 0) //left
        {
            sr.flipX = true;
        }
        else //left
        {
            sr.flipX = false;
        }
    }
}
