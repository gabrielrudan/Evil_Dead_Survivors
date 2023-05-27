using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentar : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float acceleration = 50, deacceleration = 100;

    [SerializeField]
    private Velocidade velocidadeComponent;

    private Vector2 oldMovementInput;
    public Vector2 MovementInput { get; set;}

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if (!TryGetComponent<Velocidade>(out velocidadeComponent))
        {
            print("Adicione o componente <color=orange>Velocidade</color> ao GameObject.");
        }
    }

    void FixedUpdate()
    {
        if(MovementInput.magnitude > 0 && velocidadeComponent.velocidade >= 0)
        {
            oldMovementInput = MovementInput;
            velocidadeComponent.velocidade += acceleration * velocidadeComponent.velocidadeMaxima * Time.deltaTime;
        }
        else
        {
            velocidadeComponent.velocidade -= deacceleration * velocidadeComponent.velocidadeMaxima * Time.deltaTime;
        }
        velocidadeComponent.velocidade = Mathf.Clamp(velocidadeComponent.velocidade, 0, velocidadeComponent.velocidadeMaxima);
        rb.velocity = oldMovementInput * velocidadeComponent.velocidade;
    }
    
    // public void ObtemBotao(InputAction.CallbackContext contexto)
    // {
    //     if(contexto.performed)
    //     {
    //         FixedUpdate();
    //     } 
    //     else 
    //     {
    //         print("<color=green>Erro ao chamar FixedUpdate()</color>");
    //     }
    // }

}