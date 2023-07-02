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

    private void OnTriggerEnter2D(Collider2D other) {

        WeaponManager weaponManager = other.GetComponent<WeaponManager>();
        if (other.gameObject.CompareTag("Player"))
        {
            if (weaponManager != null)
            {
                pickUpText.enabled = true;
                //weaponManager.EquipWeapon(weaponData);
            }
            //Destroy(gameObject);

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
}