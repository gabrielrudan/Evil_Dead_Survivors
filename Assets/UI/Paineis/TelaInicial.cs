using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TelaInicial : MonoBehaviour
{
    private UIDocument _doc;
    private Button btnIniciar;
    private Button btnScore;
    private Button btnSair;

    private void Awake()
    {
        _doc = GetComponent<UIDocument>();
        btnIniciar = _doc.rootVisualElement.Q<Button>("btn_iniciar");
        btnScore = _doc.rootVisualElement.Q<Button>("btn_score");
        btnSair = _doc.rootVisualElement.Q<Button>("btn_sair");

        btnIniciar.clicked += iniciarPartida;
        btnScore.clicked += verScore;
        btnSair.clicked += sairDoJogo;
    }

    private void iniciarPartida()
    {
        ScenesManager.Instance.carregaCena(ScenesManager.Scene.TelaEscolhaPersonagem);
    }

    private void verScore()
    {
        print("score");
    }

    private void sairDoJogo()
    {
        Application.Quit();
    }
}
