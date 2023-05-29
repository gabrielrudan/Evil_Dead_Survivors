using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    [SerializeField]
    private WeaponType weaponType;

    private void OnTriggerenter(Collider other) {
        WeaponManager weaponManager = other.GetComponent<WeaponManager>();
        if (weaponManager != null)
        {
            weaponManager.EquipWeapon(weaponType);
        }
        Destroy(gameObject);
    }

    public enum WeaponType
    {
        Pistola,
        Escopeta,
        Submetralhadora,
        Espingarda,
        Nova,
        Metralhadora,
        Ray,
        Explosion
    }

}
