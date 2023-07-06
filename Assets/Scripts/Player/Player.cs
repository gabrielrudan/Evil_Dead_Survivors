using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    private Movimentar agentMover;
    Animator am;
    WeaponManager weaponManager;
    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApertandoSpace = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ApertandoSpace = false;
        }

    }

    public void Atirar()
    {
        //print("Atirando");
        if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Pistola")
        {
            //print("Pistola");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Escopeta")
        {
            //print("Escopeta");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmArco>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Espingarda")
        {
            //print("Espingarda");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmArco>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Explosion")
        {
            //print("Explosion");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Metralhadora")
        {
            //print("Metralhadora");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmConeAleatorio>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Nova")
        {
            //print("Nova");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Ray")
        {
            //print("Ray");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmRetangulo>().Atira();
        }
        else if(weaponManager.equippedWeapon != null && weaponManager.equippedWeapon.weaponName == "Submetralhadora")
        {
            //print("Submetralhadora");
            GameObject PaiBala = weaponManager.currentWeapon.transform.GetChild(0).gameObject;
            PaiBala.GetComponent<AtirarEmConeAleatorio>().Atira();
        }
        
    }

}
