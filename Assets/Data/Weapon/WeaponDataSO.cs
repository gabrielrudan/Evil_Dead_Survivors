using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDataSO", menuName = "Evil_Dead_Survivors/WeaponDataSO", order = 0)]
public class WeaponDataSO : ScriptableObject {


    //Armazenar o level de cada arma, pode variar entre 1, 2 ou 3
    public Levels level;

    //Armazenar o nome da arma
    public string weaponName;
    
    //Armazenar o prefab da arma
    public GameObject weaponPrefab;
    
}