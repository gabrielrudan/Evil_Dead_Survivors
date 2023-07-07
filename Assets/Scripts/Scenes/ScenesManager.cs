using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public enum Scene
    {
        TelaInicial,
        TelaEscolhaPersonagem,
        GameMap,
        TelaPause,
        TelaGameOver
    }

    public void carregaCena(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void carregaNovoJogo()
    {
        SceneManager.LoadScene(Scene.GameMap.ToString());
    }

    public void carregaProximaCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void carregaMenu()
    {
        SceneManager.LoadScene(Scene.TelaInicial.ToString());
    }
}
