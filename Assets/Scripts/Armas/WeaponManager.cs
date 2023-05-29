using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    
    [SerializeField]
    private GameObject pistola, escopeta, submetralhadora, espingarda, nova, metralhadora, ray, explosion;

    [SerializeField]
    private Transform weaponSlot;

    private GameObject currentWeapon;

    [SerializeField]
    private Weapon.WeaponType equippedWeapon;

    //[SerializeField]
    //AudioSource pickUpSound;

    public void EquipWeapon(Weapon.WeaponType weaponType)
    {
        //pickUpSound.Play();
        
        equippedWeapon = weaponType;

        GameObject weapon = weaponType switch
        {
            Weapon.WeaponType.Pistola => pistola,
            Weapon.WeaponType.Escopeta => escopeta,
            Weapon.WeaponType.Submetralhadora => submetralhadora,
            Weapon.WeaponType.Espingarda => espingarda,
            Weapon.WeaponType.Nova => nova,
            Weapon.WeaponType.Metralhadora => metralhadora,
            Weapon.WeaponType.Ray => ray,
            Weapon.WeaponType.Explosion => explosion,
            _ => throw new System.Exception($"Logic for {weaponType.ToString()} weapon not implemented")
        };

        if(currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        currentWeapon = Instantiate(weapon);
        currentWeapon.transform.SetParent(weaponSlot);
        currentWeapon.transform.localPosition = Vector2.zero;
        currentWeapon.transform.localRotation = Quaternion.identity;

    }
}
