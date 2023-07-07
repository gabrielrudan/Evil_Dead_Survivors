using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerAtraidoPeloPlayer : MonoBehaviour
{

    Transform player;
    private Velocidade velocidadeComponent;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        print(player);
        rb = GetComponent<Rigidbody2D>();
        print(rb);
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
        {
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");
        }
    }

    void Update()
    {
        var direction = (player.position - transform.position).normalized;
        //print(direction);
        //rb.velocity = transform.position + direction * Time.deltaTime * velocidadeComponent.GetVelocidade();
        //ESSE CAPETA NAO TA SEGUINDO
        rb.MovePosition(transform.position + direction * Time.deltaTime * velocidadeComponent.GetVelocidade()); 
    }

}
