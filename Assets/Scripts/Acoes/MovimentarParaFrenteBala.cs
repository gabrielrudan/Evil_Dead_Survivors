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
        wp = transform.parent.transform.parent.gameObject.GetComponent<Animator>();
        sr = transform.parent.transform.parent.gameObject.GetComponent<SpriteRenderer>();
  
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");
    }

    void Update()
    {
        /*rb.MovePosition(transform.position + velocidadeComponent.GetVelocidade() 
            * Time.deltaTime * Vector3(1.0f, 1.0f, 0.0f));*/
            
        //print(transform.parent.position);

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

        /*if(transform.parent.position.x > 0 && transform.parent.position.y > 0){
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(1.0f, 1.0f));

        } else if(transform.parent.position.x < 0 && transform.parent.position.y > 0){
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(-1.0f, 1.0f));

        } else if(transform.parent.position.x < 0 && transform.parent.position.y < 0){
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(-1.0f, -1.0f));

        } else if(transform.parent.position.x > 0 && transform.parent.position.y < 0){
            transform.Translate(velocidadeComponent.GetVelocidade() * Time.deltaTime 
            * new Vector2(1.0f, -1.0f));
        }*/
        
    }
}
