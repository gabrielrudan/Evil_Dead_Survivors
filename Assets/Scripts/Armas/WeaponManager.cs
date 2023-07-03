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

    public List<AudioClip> weaponsPickUp;
    public AudioSource weaponPickUp;


    public void EquipWeapon(WeaponDataSO weaponData)
    {
        
        equippedWeapon = weaponData;

        if(equippedWeapon.weaponName == "Pistola")
        {
            weaponPickUp.clip = weaponsPickUp[1];
        }
        else if(equippedWeapon.weaponName == "Escopeta" || equippedWeapon.weaponName == "Espingarda")
        {
            weaponPickUp.clip = weaponsPickUp[5];
        }
        else if(equippedWeapon.weaponName == "Submetralhadora" || equippedWeapon.weaponName == "Nova")
        {
            weaponPickUp.clip = weaponsPickUp[3];
        }
        else if(equippedWeapon.weaponName == "Metralhadora")
        {
            weaponPickUp.clip = weaponsPickUp[2];
        }
        else if(equippedWeapon.weaponName == "Ray")
        {
            weaponPickUp.clip = weaponsPickUp[4];
        }
        else if(equippedWeapon.weaponName == "Explosion")
        {
            weaponPickUp.clip = weaponsPickUp[0];
        }
        else
        {
            weaponPickUp.clip = null;
        }

        weaponPickUp.Play();

        if(currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        //MOVER O OBJECTO {weaponPrefab} PARA O SLOt

        currentWeapon = Instantiate(equippedWeapon.weaponPrefab);
        Flutuar flutarScript = currentWeapon.GetComponent<Flutuar>();
        flutarScript.enabled = false;
        currentWeapon.transform.SetParent(weaponSlot);
        currentWeapon.transform.localPosition = Vector2.zero;
        currentWeapon.transform.localRotation = Quaternion.identity;



    }
}
