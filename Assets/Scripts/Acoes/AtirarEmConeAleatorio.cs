using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEmConeAleatorio : MonoBehaviour
{
    public List<GameObject> projeteis;
    [SerializeField]
    private float tempoEntreDisparos;
    [SerializeField]
    private float anguloDoCone;
    private float aleatoriedadeNaDirecao;
    private Quaternion rotacaoInicial;
    private float metadeAnguloDoCone;
    [SerializeField]
    private Transform PaiBala;

    void Start()
    {
        rotacaoInicial = transform.localRotation;
        metadeAnguloDoCone = anguloDoCone / 2;

    }

    public void Atira()
    {
    
            int rand = Random.Range(0, projeteis.Count);
            aleatoriedadeNaDirecao = Random.Range(-metadeAnguloDoCone,metadeAnguloDoCone);
            
            transform.Rotate(0.0f, 0.0f, aleatoriedadeNaDirecao, Space.Self);
            GameObject myPrefab = Resources.Load<GameObject>("Assets/Prefabs/Weapons/Balas/Normal/Normal_0.prefab");
            GameObject bala = GameObject.Instantiate(myPrefab, PaiBala.transform.position, PaiBala.transform.rotation) as GameObject;;

            transform.localRotation = rotacaoInicial;
            bala.transform.SetParent(PaiBala);
            Destroy(bala, 0.5f);

    }
}
