using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOne;

    public static bool isGameOver;
    [SerializeField]
    private GameObject telaGameOver;
    [SerializeField]
    private GameObject playerCanvas;

    private GameObject geradores;

    private void Start()
    {
        geradores = GameObject.FindGameObjectWithTag("Geradores");
        isGameOver = false;
        telaGameOver.SetActive(false);
        playerOne.GetComponent<PlayerInput>().enabled = true;
        telaGameOver.GetComponent<PlayerInput>().enabled = false;
        playerCanvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOne.gameObject.GetComponent<Vida>().GetVida() == 0)
        {
            isGameOver = true;
            geradores.SetActive(false); 
            telaGameOver.SetActive(true);
            playerOne.GetComponent<PlayerInput>().enabled = false;
            telaGameOver.GetComponent<PlayerInput>().enabled = true;
            playerCanvas.SetActive(false);
        }
        else
        {
            isGameOver = false;
        }
        
    }

}
