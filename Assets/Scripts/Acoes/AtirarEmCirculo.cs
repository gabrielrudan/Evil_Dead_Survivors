using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEmCirculo : MonoBehaviour
{
    public List<GameObject> projeteis;
    public int numeroDirecoes;
    public float tempoEntreDisparos;
    public float raioDosDisparos;
    public bool x;
    public bool y;
    public bool z;
    private float angulo;
    private Quaternion rotacaoInicial;

    ShootSounds fireEffect;

    void Start()
    {
        angulo =  360/numeroDirecoes;
        rotacaoInicial = transform.localRotation;
        fireEffect = gameObject.GetComponent<ShootSounds>();

        StartCoroutine(EsperaEAtira(0.45f));
    }

    IEnumerator EsperaEAtira(float waitTime) {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(Atira());
        fireEffect.TocarEfeitoDoTiro();
    }
 

    IEnumerator Atira()
    {
        while (true)
        {
            if(numeroDirecoes % 2 == 0){
                if (x && y  && z )
                {
                    int rand = Random.Range(0, projeteis.Count);
                    GameObject bala = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala1 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        Destroy(bala1, 0.5f);
                    }
                    transform.localRotation = rotacaoInicial;
                    GameObject bala2 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala2, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        if( i != 1)
                        {
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala3 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala3, 0.5f);
                        }
                        else if(i != numeroDirecoes-1){
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala4 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala4, 0.5f);
                        }
                    }
                    transform.localRotation = rotacaoInicial;
                }
                else if (x && y )
                {
                    int rand = Random.Range(0, projeteis.Count);
                    GameObject bala5 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala5, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala6 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        Destroy(bala6, 0.5f);
                    }
                    transform.localRotation = rotacaoInicial;
                    GameObject bala7 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala7, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        if (i != 1)
                        {
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala8 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala8, 0.5f);
                        }
                        else if (i != numeroDirecoes - 1)
                        {
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala9 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala9, 0.5f);
                        }
                    }
                    transform.localRotation = rotacaoInicial;
                }
                else if (x && z)
                {
                    int rand = Random.Range(0, projeteis.Count);
                    GameObject bala10 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala10, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala11 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        Destroy(bala11, 0.5f);
                    }
                    transform.localRotation = rotacaoInicial;
                    GameObject bala12 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                    Destroy(bala12, 0.5f);
                    for (int i = 1; i <= numeroDirecoes - 1; i++)
                    {
                        if (i != 1)
                        {
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala13 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala13, 0.5f);
                        }
                        else if (i != numeroDirecoes - 1)
                        {
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala14 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            Destroy(bala14, 0.5f);
                        }
                    }
                    transform.localRotation = rotacaoInicial;
                }
                else if (x)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala15 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala15, 0.5f);
                    }
                }
                else if (y)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                        GameObject bala16 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala16, 0.5f);
                    }
                }
                else if (z)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(0.0f, 0.0f, angulo * i, Space.Self);
                        GameObject bala17 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        //bala17.transform.parent = gameObject.transform;
                        Destroy(bala17, 0.5f);
                    }
                }
            }
            else
            {
                if(x && y && z)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala18 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala18, 0.5f);
                    }
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        if(i != 0 || i != numeroDirecoes )
                        {
                            int rand = Random.Range(0, projeteis.Count);
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala19 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            transform.localRotation = rotacaoInicial;
                            Destroy(bala19, 0.5f);
                        }
                    }
                }
                if(x && y)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala20 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala20, 0.5f);
                    }
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        if(i != 0 || i != numeroDirecoes )
                        {
                            int rand = Random.Range(0, projeteis.Count);
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala21 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            transform.localRotation = rotacaoInicial;
                            Destroy(bala21, 0.5f);
                        }
                    }
                }
                if(x && z)
                {
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala22 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala22, 0.5f);
                    }
                    for (int i = 0; i < numeroDirecoes; i++)
                    {
                        if(i != 0 || i != numeroDirecoes )
                        {
                            int rand = Random.Range(0, projeteis.Count);
                            transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                            GameObject bala23 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                            transform.localRotation = rotacaoInicial;
                            Destroy(bala23, 0.5f);
                        }
                    }
                }
                else if(x)
                {
                    for (int i = 0; i < numeroDirecoes ; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(angulo * i, 0.0f, 0.0f, Space.Self);
                        GameObject bala24 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala24, 0.5f);
                    }
                    
                }
                else if(y)
                {
                    for (int i = 0; i < numeroDirecoes ; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(0.0f, angulo * i, 0.0f, Space.Self);
                        GameObject bala25 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala25, 0.5f);
                    }
                    
                }
                else if(z)
                {
                    for (int i = 0; i < numeroDirecoes ; i++)
                    {
                        int rand = Random.Range(0, projeteis.Count);
                        transform.Rotate(0.0f, 0.0f, angulo * i, Space.Self);
                        GameObject bala26 = Instantiate(projeteis[rand], transform.position, transform.rotation);
                        transform.localRotation = rotacaoInicial;
                        Destroy(bala26, 0.5f);
                    }
                    
                }
            }

            yield return new WaitForSeconds(tempoEntreDisparos);
        }
    }
}
