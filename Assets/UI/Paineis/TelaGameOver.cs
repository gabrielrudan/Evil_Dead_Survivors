using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TelaGameOver : MonoBehaviour
{
    [SerializeField] private GameObject playerOne;

    private int btnSelecionado = 1;

    private void Start()
    {
        /*playerOne.gameObject.GetComponent<PlayerInput>().enabled = false;
        this.gameObject.GetComponent<PlayerInput>().enabled = true;
        print("no start");*/
    }

    public void OnSelected()
    {
        print("no selected");
        if (btnSelecionado == 1)
        {
            loadMenu();
        }
    }
    

    public void loadMenu()
    {
        print("Clicando");
        ScenesManager.Instance.carregaMenu();
    }
}
