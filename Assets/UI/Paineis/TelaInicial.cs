using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TelaInicial : MonoBehaviour
{
    public void iniciarPartida()
    {
        ScenesManager.Instance.carregaCena(ScenesManager.Scene.TelaEscolhaPersonagem);
    }

    public void sairDoJogo()
    {
        Application.Quit();
    }
}
