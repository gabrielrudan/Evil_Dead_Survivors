using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    [SerializeField]
    private WeaponType weaponType;

    private void OnTriggerEnter2D(Collider2D other) {
        WeaponManager weaponManager = other.GetComponent<WeaponManager>();
        if (other.gameObject.CompareTag("Player"))
        {
            print("Colidiu com o jogador !!!");
            if (weaponManager != null)
            {
                weaponManager.EquipWeapon(weaponType);
            }
            Destroy(gameObject);
        }
    }
}