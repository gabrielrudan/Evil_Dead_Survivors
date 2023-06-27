using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    [SerializeField]
    private Transform weaponSlot;

    private GameObject currentWeapon;

    [SerializeField]
    public WeaponDataSO equippedWeapon;

    //[SerializeField]
    //AudioSource pickUpSound;

    public void EquipWeapon(WeaponDataSO weaponData)
    {
        //pickUpSound.Play();
        
        equippedWeapon = weaponData;

        if(currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        //MOVER O OBJECTO {weapon} PARA O SLOT

        //currentWeapon = Instantiate(weapon);
        //currentWeapon.transform.SetParent(weaponSlot);
        //currentWeapon.transform.localPosition = Vector2.zero;
        //currentWeapon.transform.localRotation = Quaternion.identity;

    }
}
