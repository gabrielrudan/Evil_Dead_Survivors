using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimentar : MonoBehaviour
{
    public Rigidbody2D rb;

    [SerializeField]
    private float acceleration = 5, deacceleration = 10;

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

}
