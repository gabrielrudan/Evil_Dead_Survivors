using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    
    Animator am;
    Player pm;
    SpriteRenderer sr;
    WeaponManager wp;

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

            //Animator amWeapon = wp.equippedWeapon.weaponPrefab.GetComponent<Animator>();
            //amWeapon.SetBool("ArmaPega", true);

            if(wp.equippedWeapon.weaponName == "Pistola" || wp.equippedWeapon.weaponName == "Nova" || wp.equippedWeapon.weaponName == "Submetralhadora" || wp.equippedWeapon.weaponName == "Ray")
            {
                am.SetBool("SegurandoPistola", true);
                am.SetBool("SegurandoMetralha", false);
            }
            if(wp.equippedWeapon.weaponName == "Escopeta" || wp.equippedWeapon.weaponName == "Espingarda" || wp.equippedWeapon.weaponName == "Explosion" || wp.equippedWeapon.weaponName == "Metralhadora")
            {
                am.SetBool("SegurandoMetralha", true);
                am.SetBool("SegurandoPistola", false);
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
