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
                    PaiBala.transform.localPosition = new Vector3((float)-0.0786999986,(float)0.0707999989,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0786999986,(float)0.0707999989,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.100100003,(float)-0.0640999973,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.100100003,(float)-0.0640999973,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0786999986,(float)0.0707999989,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0786999986,(float)0.0707999989,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.100100003,(float)-0.0640999973,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.100100003,(float)-0.0640999973,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ------------------------------------ > ESCOPETA < --------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Escopeta")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.224999994,(float)0.142299995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.224999994,(float)0.142299995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.278499991,(float)-0.141000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.278499991,(float)-0.141000003,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.224999994,(float)0.142299995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.224999994,(float)0.142299995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.278499991,(float)-0.141000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.278499991,(float)-0.141000003,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // -------------------------------- > SUBMETRALHADORA < -----------------------------------------------

        if(wp.equippedWeapon.weaponName == "Submetralhadora")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0786999986,(float)0.0623000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0786999986,(float)0.0623000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0864999965,(float)-0.060899999,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0864999965,(float)-0.060899999,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0786999986,(float)0.0623000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0786999986,(float)0.0623000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0864999965,(float)-0.060899999,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0864999965,(float)-0.060899999,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------- > ESPINGARDA < -------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Espingarda")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.171499997,(float)0.124399997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.171499997,(float)0.124399997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.277200013,(float)-0.130600005,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.277200013,(float)-0.130600005,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.171499997,(float)0.124399997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.171499997,(float)0.124399997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.277200013,(float)-0.130600005,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.277200013,(float)-0.130600005,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ----------------------------- > NOVA SUBMETRALHADORA < ---------------------------------------------

        if(wp.equippedWeapon.weaponName == "Nova")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0997999981,(float)0.0299999993,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0997999981,(float)0.0299999993,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0868000016,(float)-0.0634000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0868000016,(float)-0.0634000003,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0997999981,(float)0.0299999993,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0997999981,(float)0.0299999993,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.0868000016,(float)-0.0634000003,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.0868000016,(float)-0.0634000003,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ---------------------------------- > METRALHADORA < ------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Metralhadora")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.219999999,(float)0.136999995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.219999999,(float)0.136999995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.1963,(float)-0.130999997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.1963,(float)-0.130999997,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.219999999,(float)0.136999995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.219999999,(float)0.136999995,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.1963,(float)-0.130999997,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.1963,(float)-0.130999997,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // -------------------------------------- > RAY GUN < -------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Ray")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.070600003,(float)0.0870999992,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.070600003,(float)0.0870999992,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.110799998,(float)-0.0625,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.110799998,(float)-0.0625,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.070600003,(float)0.0870999992,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.070600003,(float)0.0870999992,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.110799998,(float)-0.0625,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.110799998,(float)-0.0625,0);
                }
            }
        }

        // ----------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------------
        // ------------------------------------- > EXPLOSION < ------------------------------------------------

        if(wp.equippedWeapon.weaponName == "Explosion")
        {
            if(pam.GetBool("Andando") == true)
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.319499999,(float)0.154100001,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.319499999,(float)0.154100001,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.304500014,(float)-0.144999996,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.304500014,(float)-0.144999996,0);
                }
            }
            else
            {
                if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.319499999,(float)0.154100001,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.319499999,(float)0.154100001,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                {
                    PaiBala.transform.localPosition = new Vector3((float)-0.304500014,(float)-0.144999996,0);
                }
                else if(pam.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                {
                    PaiBala.transform.localPosition = new Vector3((float)0.304500014,(float)-0.144999996,0);
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
