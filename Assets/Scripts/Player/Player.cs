using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    private Movimentar agentMover;
    
    [SerializeField]
    public Vector2 movementInput;
    
    [SerializeField]
    private InputActionReference movement, attack, shoot;
    
    private void Awake() 
    {
        agentMover = GetComponent<Movimentar>();
    }

    void Update()
    {
        movementInput = movement.action.ReadValue<Vector2>();
        agentMover.MovementInput = movementInput;
    }
}
