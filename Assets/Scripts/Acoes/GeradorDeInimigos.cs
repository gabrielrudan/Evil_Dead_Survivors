using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeradorDeInimigos : MonoBehaviour
{

    public List<GameObject> prefabs;
    public int qnt;
    public float espaco;
    public bool serDestruido;

    private void Start()
    {
        if (qnt > 0)
        {
            StartCoroutine(Wait(espaco));
        }
        else
        {
            StartCoroutine(Wait(espaco));
        }
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        StartCoroutine(GerarGameObject());
    }


    IEnumerator GerarGameObject()
    {
        while(true)
        {
            int rand = Random.Range(0, prefabs.Count);
            Instantiate(prefabs[rand], transform.position, transform.rotation);
            qnt--;

            if (qnt == 0 && serDestruido)
            {
                Destroy(gameObject);
            }

            yield return new WaitForSeconds(espaco);
        }
    }

}