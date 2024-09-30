using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    public Vector2 MoveValue;
    public float MoveSpeed;

    void OnMove(InputValue value)
    {
        MoveValue = value.Get<Vector2>();
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveValue.x, 0.0f, moveValue.y);
        
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.fixedDeltaTime);
    }
}
