using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputRead : MonoBehaviour
{
    public Vector3 Direction;
    // public Rigidbody rb;
    public bool IsJump{get;private set;}

    PlayerInput _playerInput;
    Rigidbody rb;

    private void Awake() {
         _playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();

         CreatureInput creatureInput = new CreatureInput();
         creatureInput.Creature.Enable();
        creatureInput.Creature.Jump.performed += Jump;
        
        
    //    _playerInput.onActionTriggered += Jump;
        
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Direction);
    }

    public void MoveCreature(InputAction.CallbackContext context)
    {
        Vector2 TwoDInput = context.ReadValue<Vector2>();
        Direction = new Vector3(TwoDInput.x, 0f, TwoDInput.y);
    }
    public void Jump(InputAction.CallbackContext context)
    {
        // Debug.Log("Jumped!");
        // rb.AddForce(Vector3.up * _speed, ForceMode.Force);
        // IsJump = context.ReadValueAsButton();
        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        Debug.Log(context.phase);

        

    }
}
