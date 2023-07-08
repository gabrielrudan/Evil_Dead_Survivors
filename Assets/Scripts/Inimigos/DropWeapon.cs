using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropWeapon : MonoBehaviour
{
    
    [SerializeField]
    private GameObject pickableWeapon;
    [SerializeField]
    public bool podeDropar;
    public int dropCount;

    private void Start() {

        dropCount = 0;

        int rand = Random.Range(0, 10);
        if(rand == 1)
        {
            podeDropar = true;
        }
        else
        {
            podeDropar = false;
        }

    }

    public void DroparArma()
    {
        Instantiate(pickableWeapon, gameObject.transform.position, Quaternion.identity);
        dropCount++;
    }


}
