using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    
    Animator am;
    Player pm;
    SpriteRenderer sr;
    WeaponManager wp;

    [SerializeField]
    private Transform weaponSlot;

    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<Player>();
        sr = GetComponent<SpriteRenderer>();
        wp = GetComponent<WeaponManager>();
    }

    void Update()
    {

        if(wp.equippedWeapon == null)
        {
            am.SetBool("SegurandoPistola", false);
            am.SetBool("SegurandoMetralha", false);
        }
        else{

            if(wp.equippedWeapon.weaponName == "Pistola" || wp.equippedWeapon.weaponName == "Nova" || wp.equippedWeapon.weaponName == "Submetralhadora" || wp.equippedWeapon.weaponName == "Ray")
            {
                am.SetBool("SegurandoPistola", true);
                am.SetBool("SegurandoMetralha", false);

                //TEM QUE VERIFICAR SE TA ANDANDO ANTES

                if(am.GetBool("OlhandoParaCima") == true)
                {
                    if(pm.movementInput.x < 0) //flipa
                    {
                        print("flipou andando");
                        weaponSlot.transform.localPosition = new Vector3((float)-0.196199998, (float)0.415499985, 0);
                    }
                    else //nao flipa
                    {
                        print("nao flipou andando");
                        weaponSlot.transform.localPosition = new Vector3((float)0.196199998, (float)0.415499985, 0);
                    }
                }
                else
                {
                    if(pm.movementInput.x < 0) //flipa
                    {
                        print("flipou");
                        weaponSlot.transform.localPosition = new Vector3((float)-0.219999999, (float)0.164000005, 0);
                    }
                    else //nao flipa
                    {
                        print("nao flipou");
                        weaponSlot.transform.localPosition = new Vector3((float)0.219999999, (float)0.164000005, 0);
                    }
                }
            }
            if(wp.equippedWeapon.weaponName == "Escopeta" || wp.equippedWeapon.weaponName == "Espingarda" || wp.equippedWeapon.weaponName == "Explosion" || wp.equippedWeapon.weaponName == "Metralhadora")
            {
                am.SetBool("SegurandoMetralha", true);
                am.SetBool("SegurandoPistola", false);

                if(am.GetBool("OlhandoParaCima") == true)
                {
                    weaponSlot.transform.localPosition = new Vector3((float)0.0329999998, (float)0.247999996, 0);
                }
                else
                {
                    weaponSlot.transform.localPosition = new Vector3((float)0.0289999992, (float)0.138999999, 0);
                }
            }
        }

        if(pm.movementInput.x == 0 && pm.movementInput.y == 0)
        {
            am.SetBool("Andando", false);

            if(pm.movementInput.x > 0 && pm.movementInput.y == 0) //right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y == 0) //left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x == 0 && pm.movementInput.y > 0) //up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x == 0 && pm.movementInput.y < 0) //down
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoParaCima", false);
            }

        }

        else
        {
            am.SetBool("Andando", true);

            SpriteDirectChecker();

            if(pm.movementInput.x > 0 && pm.movementInput.y > 0) //right-up
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x > 0 && pm.movementInput.y < 0) //down-right
            {
                am.SetBool("OlhandoParaCima", false);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y > 0) //up-left
            {
                am.SetBool("OlhandoParaCima", true);
            }

            else if(pm.movementInput.x < 0 && pm.movementInput.y < 0) //left-down
            {
                am.SetBool("OlhandoParaCima", false);
            }
        }
    }

    void SpriteDirectChecker()
    {
        if(pm.movementInput.x < 0) //flipa
        {
            sr.flipX = true;
        }
        else //nao flipa
        {
            sr.flipX = false;
        }
    }
}
