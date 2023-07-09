using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    public Movimentar agentMover;
    Animator am;
    public WeaponManager weaponManager;
    
    [SerializeField]
    public Vector2 movementInput;
    
    [SerializeField]
    private InputActionReference movement, attack, shoot;

    public static bool ApertandoSpace = false;

    private void Awake() 
    {
        agentMover = GetComponent<Movimentar>();
        am = GetComponent<Animator>();
        weaponManager = GetComponent<WeaponManager>();
    }

    void Update()
    {
        movementInput = movement.action.ReadValue<Vector2>();

        if(movementInput.x > 0 && movementInput.y == 0) //right
        {
            movementInput.y = movementInput.x;
        }

        else if(movementInput.x == 0 && movementInput.y > 0) //up
        {
            movementInput.x = movementInput.y * -1;
        }

        else if(movementInput.x < 0 && movementInput.y == 0) //left
        {
            movementInput.y = movementInput.x;
        }

        else if(movementInput.x == 0 && movementInput.y < 0) //down
        {
            movementInput.x = movementInput.y * -1;
        }

        agentMover.MovementInput = movementInput;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            ApertandoSpace = true;
        }
        if (Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.JoystickButton4))
        {
            ApertandoSpace = false;
        }

    }

    public void Atirar()
    {
        print("Atirando");
        if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Pistola")
        {
            
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Escopeta")
        {
            
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmArco>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Espingarda")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmArco>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Explosion")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmRetangulo>().Atira();     
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Metralhadora")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmConeAleatorio>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Nova")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Ray")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Submetralhadora")
        {
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            if(weaponManager.currentWeapon.GetComponent<Balas>().quantidadeDeBalas > 0)
            {
                PaiBala.GetComponent<AtirarEmConeAleatorio>().Atira();
                PaiBala.GetComponent<ShootSounds>().TocarEfeitoDoTiro();

                weaponManager.currentWeapon.GetComponent<Balas>().SetQuantidadeDeBalas(
                    weaponManager.currentWeapon.GetComponent<Balas>().GetQuantidadeBalas()
                    - 1
                );
            }
            else
            {
                PaiBala.GetComponent<ShootSounds>().TocarSemBalas();
            }
        }
        
    }

}
