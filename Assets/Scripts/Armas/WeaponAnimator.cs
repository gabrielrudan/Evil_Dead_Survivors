using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAnimator : MonoBehaviour
{
    Animator am;
    Player pm;
    SpriteRenderer sr;

    [SerializeField]
    public GameObject weaponPrefab;

    void Start()
    {
        am = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        pm = weaponPrefab.transform.parent.transform.parent.gameObject.GetComponent<Player>();
    }

    void Update()
    {
        am.SetBool("ArmaPega", true);

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
