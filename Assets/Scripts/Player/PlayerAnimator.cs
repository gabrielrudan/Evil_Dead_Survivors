using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    
    Animator am;
    Player pm;
    SpriteRenderer sr;
    WeaponManager wp;
    Vida vida;

    [SerializeField]
    private Transform weaponSlot;

    [SerializeField]
    private SimpleFlash flashEffect;
    [SerializeField] 
    private DamageSounds damageSounds;

    Knockback knockback;

    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<Player>();
        sr = GetComponent<SpriteRenderer>();
        wp = GetComponent<WeaponManager>();
        flashEffect = GetComponent<SimpleFlash>();
        vida = GetComponent<Vida>();
        damageSounds = GetComponent<DamageSounds>();
        knockback = GetComponent<Knockback>();
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
            if(pm.weaponManager.equippedWeapon != null)
            {
                pm.weaponManager.equippedWeapon = null;
                Destroy(pm.weaponManager.currentWeapon);
            }
            pm.agentMover.MovementInput = Vector2.zero;
            knockback.SetForce(0.0f);
            this.enabled = false;
            pm.enabled = false;
        }

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

                if(am.GetBool("Andando") == true)
                {
                    if(am.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.196199998, (float)0.415499985, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.196199998, (float)0.415499985, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.219999999, (float)0.164000005, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.219999999, (float)0.164000005, 0);
                    }
                }
                else
                {
                    if(am.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.196199998, (float)0.415499985, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.196199998, (float)0.415499985, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.219999999, (float)0.164000005, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.219999999, (float)0.164000005, 0);
                    }
                }
            }
            if(wp.equippedWeapon.weaponName == "Escopeta" || wp.equippedWeapon.weaponName == "Espingarda" || wp.equippedWeapon.weaponName == "Explosion" || wp.equippedWeapon.weaponName == "Metralhadora")
            {
                am.SetBool("SegurandoMetralha", true);
                am.SetBool("SegurandoPistola", false);

                if(am.GetBool("Andando") == true)
                {
                    if(am.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.1029999998, (float)0.277999996, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.1029999998, (float)0.277999996, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.0289999992, (float)0.138999999, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.0289999992, (float)0.138999999, 0);
                    }
                }
                else
                {
                    if(am.GetBool("OlhandoParaCima") == true && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.1029999998, (float)0.277999996, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == true && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.1029999998, (float)0.277999996, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == true)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)-0.0289999992, (float)0.138999999, 0);
                    }
                    else if(am.GetBool("OlhandoParaCima") == false && sr.flipX == false)
                    {
                        weaponSlot.transform.localPosition = new Vector3((float)0.0289999992, (float)0.138999999, 0);
                    }
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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(vida.GetVida() > 0)
        {
            if (other.gameObject.CompareTag("Inimigo"))
            {
                damageSounds.TocarDamageSound();
                flashEffect.Flash();
            }
        }
        else
        {
            flashEffect.Flash();
            damageSounds.TocarDeathSound();
        }
    }
}
