using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOne;

    // Update is called once per frame
    void Update()
    {
        print(Clock.Instance.getLastTime());
    }

    private bool AreThePlayersAlive()
    {
        if (playerOne.gameObject.GetComponent<Vida>().GetVida() == 0) 
        {
            return true;
        }

        return false;
    }
}
