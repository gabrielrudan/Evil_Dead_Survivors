using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TelaInicial : MonoBehaviour
{
    private int btnSelecionado = 1;

    public void onSelect()
    {
        if(btnSelecionado == 1)
        {
            iniciarPartida();
        } else if (btnSelecionado == 2)
        {
            sairDoJogo();
        }
    }

    private void iniciarPartida()
    {
        ScenesManager.Instance.carregaCena(ScenesManager.Scene.TelaEscolhaPersonagem);
    }

    private void sairDoJogo()
    {
        Application.Quit();
    }
}
