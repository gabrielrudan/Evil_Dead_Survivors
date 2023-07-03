using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    
    private Movimentar agentMover;
    Animator am;
    
    [SerializeField]
    public Vector2 movementInput;
    
    [SerializeField]
    private InputActionReference movement, attack, shoot;

    public static bool ApertandoSpace = false;

    private void Awake() 
    {
        agentMover = GetComponent<Movimentar>();
        am = GetComponent<Animator>();
    }

    void Update()
    {
        movementInput = movement.action.ReadValue<Vector2>();

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApertandoSpace = true;
        }

    }

}
