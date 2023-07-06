using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEmArco : MonoBehaviour
{
    public List<GameObject> projeteis;
    public int qtdDeLinhas;
    public float tempoEntreDisparos;
    public float distanciaLinhaDeTiros;

    //[SerializeField]
    //private Transform PaiBala;

    private GameObject bala;

    void Start() {
        //PaiBala = gameObject.transform.GetChild(0).transform;
    }

    public void Atira()
    {

        //print(PaiBala);
       
            int i = qtdDeLinhas / 2;
            float metadeDaDistancia = distanciaLinhaDeTiros / 2;
            if (qtdDeLinhas % 2 == 0)
                for (int j = -i; j < i; j++)
                {
                    int rand = Random.Range(0, projeteis.Count);
                    bala = Instantiate<GameObject>(projeteis[rand], 
                        new Vector2(transform.position.x, 
                            transform.position.y + (j * distanciaLinhaDeTiros) + metadeDaDistancia),
                            transform.rotation);

                    bala.transform.SetParent(gameObject.transform);
                    Destroy(bala, 0.5f);
                }
            else
                for (int j = -i; j <= i; j++)
                {
                    int rand = Random.Range(0, projeteis.Count);
                    bala = Instantiate<GameObject>(projeteis[rand],
                        new Vector2(transform.position.x,
                            transform.position.y + j * distanciaLinhaDeTiros),
                            transform.rotation
                        );

                    bala.transform.SetParent(gameObject.transform);
                    Destroy(bala, 0.5f);
                }

    }
}
