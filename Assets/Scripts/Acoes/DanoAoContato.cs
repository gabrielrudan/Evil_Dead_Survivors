using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoAoContato : MonoBehaviour
{
    [Header("Tag do gameObject que recebera o dano")]
    public string outroTag;
    public bool seDestroiNoContato;
    private Dano danoComponent;

    void Start()
    {
        if (!TryGetComponent<Dano>(out danoComponent))
        {
            print("Adicione o componente <color=orange>Dano</color> ao GameObject.");
        }
    }

    public void OnTriggerEnter2D(Collider2D outro) 
    {
        if (outro.gameObject.CompareTag(outroTag))
        {
            outro.gameObject.GetComponent<Vida>().SetVida(
                outro.gameObject.GetComponent<Vida>().GetVida()
                - danoComponent.GetDano()
            );

            if (seDestroiNoContato)
                Destroy(gameObject);
        }
    }
}
