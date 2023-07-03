using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telapersonagens : MonoBehaviour
{
    private int btnSelecionado = 1;

    public void onSelect()
    {
        if (btnSelecionado == 1)
        {
            iniciarPartida();
        }

    }

    private void iniciarPartida()
    {
        ScenesManager.Instance.carregaNovoJogo();
    }
}
