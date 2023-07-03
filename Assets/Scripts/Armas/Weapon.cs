using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    [SerializeField]
    private WeaponDataSO weaponData;

    public PickableWeapon pw;

    public Canvas pickUpText;

    
    void Start()
    {
        weaponData = pw.weaponData;
        pickUpText.enabled = false;
    }

    void Update()
    {

    }

    public void OnTriggerStay2D(Collider2D other) {

        WeaponManager weaponManager = other.GetComponent<WeaponManager>();

        if (other.gameObject.CompareTag("Player"))
        {
            if (weaponManager != null)
            {
                pickUpText.enabled = true;
                if (Player.ApertandoSpace)
                {
                    weaponManager.EquipWeapon(weaponData);
                    Player.ApertandoSpace = false;
                    Destroy(gameObject);
                }
            }

        }
    }

    private void OnTriggerExit2D(Collider2D other) {

        WeaponManager weaponManager = other.GetComponent<WeaponManager>();
        if (other.gameObject.CompareTag("Player"))
        {
            if (weaponManager != null)
            {
                pickUpText.enabled = false;
            }

        }
    }

    public void DestroyWeapon()
    {
        Destroy(gameObject);
    }
}