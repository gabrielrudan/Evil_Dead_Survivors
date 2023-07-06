using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarParaFrenteBala : MonoBehaviour
{
    private Rigidbody2D rb;
    private Velocidade velocidadeComponent;
    Animator wp;
    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        wp = transform.parent.transform.parent.GetComponent<Animator>();
        sr = transform.parent.transform.parent.GetComponent<SpriteRenderer>();
  
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");
    }

    void Update()
    {

        if(wp.GetBool("OlhandoPraCima") == true && sr.flipX == true)
        {
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(-1.0f, 1.0f));
        }
        else if(wp.GetBool("OlhandoPraCima") == true && sr.flipX == false)
        {
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(1.0f, 1.0f));
        }
        else if(wp.GetBool("OlhandoPraCima") == false && sr.flipX == true)
        {
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(-1.0f, -1.0f));
        }
        else if(wp.GetBool("OlhandoPraCima") == false && sr.flipX == false)
        {
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(1.0f, -1.0f));
        }
        
    }
}
