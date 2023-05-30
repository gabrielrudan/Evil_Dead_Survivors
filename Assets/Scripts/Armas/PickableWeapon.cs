using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableWeapon : MonoBehaviour
{
    
    public List<GameObject> weaponPrefabs;
    public GameObject weapon;
    
    void Start()
    {   
        //SpawnWeapons();
    }

    void Update()
    {
        
    }

    public int SpawnWeapons()
    {
        int rand = Random.Range(0, weaponPrefabs.Count);
        weapon = Instantiate(weaponPrefabs[rand], gameObject.transform.position, Quaternion.identity);
        weapon.transform.parent = gameObject.transform;

        return rand;
    }

}
