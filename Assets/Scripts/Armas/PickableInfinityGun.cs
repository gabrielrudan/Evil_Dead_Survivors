using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableInfinityGun : MonoBehaviour
{
    public List<WeaponDataSO> weaponDatas;
    public GameObject weapon;
    public WeaponDataSO weaponData;
    private Animator am;
    
    void Start()
    {   
        SpawnWeapons();
    }


    public void SpawnWeapons()
    {
        int rand = Random.Range(0, weaponDatas.Count);
        weaponData = weaponDatas[rand];
        weapon = Instantiate(weaponDatas[rand].weaponPrefab, gameObject.transform.position, Quaternion.identity);
        weapon.transform.parent = gameObject.transform;
        am = weapon.GetComponent<Animator>();
        am.SetBool("Infinity", true);
    }
}
