using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerAtraidoPeloPlayer : MonoBehaviour
{

    Transform player;
    private Velocidade velocidadeComponent;
    private Rigidbody2D rb;
    private Movimentar agentMover;
    public Vector2 movementInput;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        agentMover = GetComponent<Movimentar>();
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
        {
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");
        }
    }

    void Update()
    {
        var direction = (player.position - transform.position).normalized;

        movementInput = new Vector2(direction.x, direction.y);

        if(movementInput.x > 0 && movementInput.y == 0) //right
        {
            movementInput.y = movementInput.x;
        }

        else if(movementInput.x == 0 && movementInput.y > 0) //up
        {
            movementInput.x = movementInput.y * -1;
        }

        else if(movementInput.x < 0 && movementInput.y == 0) //left
        {
            movementInput.y = movementInput.x;
        }

        else if(movementInput.x == 0 && movementInput.y < 0) //down
        {
            movementInput.x = movementInput.y * -1;
        }

        agentMover.MovementInput = movementInput;

        //rb.velocity = (transform.position + direction * Time.deltaTime * velocidadeComponent.GetVelocidade()); 
    }

}
