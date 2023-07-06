using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEmArco : MonoBehaviour
{
    public List<GameObject> projeteis;
    public int qtdDeLinhas;
    public float tempoEntreDisparos;
    public float distanciaLinhaDeTiros;

    [SerializeField]
    private Transform PaiBala;

    private GameObject bala;
    
    public void Atira()
    {
        
            int i = qtdDeLinhas / 2;
            float metadeDaDistancia = distanciaLinhaDeTiros / 2;
            if (qtdDeLinhas % 2 == 0)
                for (int j = -i; j < i; j++)
                {
                    int rand = Random.Range(0, projeteis.Count);
                    bala = Instantiate<GameObject>(projeteis[rand]);
                    Instantiate((GameObject)bala,
                        new Vector2(PaiBala.transform.position.x, 
                            PaiBala.transform.position.y + (j * distanciaLinhaDeTiros) + metadeDaDistancia),
                            PaiBala.transform.rotation
                        );

                    bala.transform.SetParent(PaiBala);
                    Destroy(bala, 0.5f);
                }
            else
                for (int j = -i; j <= i; j++)
                {
                    int rand = Random.Range(0, projeteis.Count);
                    bala = Instantiate<GameObject>(projeteis[rand]);
                    Instantiate((GameObject)bala,
                        new Vector2(PaiBala.transform.position.x,
                            PaiBala.transform.position.y + j * distanciaLinhaDeTiros),
                            PaiBala.transform.rotation
                        );
                    bala.transform.SetParent(PaiBala);
                    Destroy(bala, 0.5f);
                }
    }
}
