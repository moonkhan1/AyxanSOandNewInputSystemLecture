using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    Rigidbody rb;
    InputRead _input;
   float _speed = 8f;
   Animator _anim;
    void Start()
    {
        _input = GetComponent<InputRead>();
        rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(_input.IsJump)
        // {
        //     rb.AddForce(Vector3.up * 50f * Time.fixedDeltaTime, ForceMode.Impulse);
        // }
        Debug.Log(_input.IsJump);
        rb.MovePosition(transform.position + _input.Direction * _speed * Time.fixedDeltaTime);
        // rb.AddForce(_input.Direction * _speed, ForceMode.Force);
        _anim.SetFloat("Vertical", _input.Direction.z);
        _anim.SetFloat("Horizontal", _input.Direction.x);
    }
}
