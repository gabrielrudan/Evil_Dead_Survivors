using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEmRetangulo : MonoBehaviour
{
    public List<GameObject> projeteis;
    public int qtdDeLinhas;
    public float tempoEntreDisparos;
    public float distanciaLinhaDeTiros;

    [SerializeField]
    private Transform PaiBala;

    void Start()
    {
        StartCoroutine(AtirarRetangulos());
    }

    IEnumerator AtirarRetangulos()
    {
        while (true)
        {
            int rand = Random.Range(0, projeteis.Count);
            int i = qtdDeLinhas / 2;
            float metadeDaDistancia = distanciaLinhaDeTiros / 2;
            if (qtdDeLinhas % 2 == 0)
                for (int j = -i; j < i; j++)
                {
                    GameObject bala = Instantiate(projeteis[rand],
                        new Vector2(PaiBala.transform.position.x, 
                            PaiBala.transform.position.y + (j * distanciaLinhaDeTiros) + metadeDaDistancia),
                            PaiBala.transform.rotation
                        );

                    bala.transform.parent = PaiBala.transform;
                    Destroy(bala, 0.5f);
                }
            else
                for (int j = -i; j <= i; j++)
                {
                    GameObject bala = Instantiate(projeteis[rand],
                        new Vector2(PaiBala.transform.position.x,
                            PaiBala.transform.position.y + j * distanciaLinhaDeTiros),
                            PaiBala.transform.rotation
                        );
                    bala.transform.parent = PaiBala.transform;
                    Destroy(bala, 0.5f);
                }


            yield return new WaitForSeconds(tempoEntreDisparos);
        }
    }
}
