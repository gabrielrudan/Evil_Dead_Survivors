using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityGun : MonoBehaviour
{
    [SerializeField]
    private WeaponDataSO weaponData;

    public PickableInfinityGun pw;

    public Canvas pickUpText;

    Animator am;

    
    void Start()
    {
        pw = GetComponent<PickableInfinityGun>();
        weaponData = pw.weaponData;
        pickUpText.enabled = false;
        //am = weaponData.weaponPrefab.GetComponent<Animator>();
        //print(am);
        //am.SetBool("Infinity", true);
    }

    void Update()
    {
        weaponData = pw.weaponData;
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
}
