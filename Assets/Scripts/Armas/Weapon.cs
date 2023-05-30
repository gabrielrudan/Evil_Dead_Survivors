using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private int weaponId;
    
    [SerializeField]
    private WeaponType weaponType;

    [SerializeField]
    private PickableWeapon pw;

    void Start()
    {
        weaponId = pw.SpawnWeapons();

        Associar(weaponId);
    }

    void Associar(int id)
    {
        if(id == 0)
        {
            weaponType = WeaponType.Pistola;
        }
        else if(id == 1)
        {
            weaponType = WeaponType.Submetralhadora;
        }
        else if(id == 2)
        {
            weaponType = WeaponType.Espingarda;
        }
        else if(id == 3)
        {
            weaponType = WeaponType.Escopeta;
        }
        else if(id == 4)
        {
            weaponType = WeaponType.Nova;
        }
        else if(id == 5)
        {
            weaponType = WeaponType.Metralhadora;
        }
        else if(id == 6)
        {
            weaponType = WeaponType.Ray;
        }
        else if(id == 7)
        {
            weaponType = WeaponType.Explosion;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        WeaponManager weaponManager = other.GetComponent<WeaponManager>();
        if (other.gameObject.CompareTag("Player"))
        {
            print(weaponId);
            if (weaponManager != null)
            {
                weaponManager.EquipWeapon(weaponType);
            }
            Destroy(gameObject);
        }
    }
}