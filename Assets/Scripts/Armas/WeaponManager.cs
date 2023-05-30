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
    private WeaponType equippedWeapon;

    //[SerializeField]
    //AudioSource pickUpSound;

    public void EquipWeapon(WeaponType weaponType)
    {
        //pickUpSound.Play();
        
        equippedWeapon = weaponType;

        GameObject weapon = weaponType switch
        {
            WeaponType.Pistola => pistola,
            WeaponType.Escopeta => escopeta,
            WeaponType.Submetralhadora => submetralhadora,
            WeaponType.Espingarda => espingarda,
            WeaponType.Nova => nova,
            WeaponType.Metralhadora => metralhadora,
            WeaponType.Ray => ray,
            WeaponType.Explosion => explosion,
            _ => throw new System.Exception($"Logic for {weaponType.ToString()} weapon not implemented")
        };

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
