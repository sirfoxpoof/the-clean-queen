using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private PlayerInputActions input;
    public Rigidbody rb;
    public GameObject camHold;
    public float speed, sens, sprint, jumpHight;

    private Vector2 move, look;
    private Vector3 jump;

    private InputAction movew, rotate;
    private float x, y;

    private void Awake()
    {
        input = new PlayerInputActions();
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        movew = input.Movement.WASD;
        movew.Enable();

        rotate = input.Movement.Mouse;
        rotate.Enable();
    }

    private void OnDisable()
    {
        movew.Disable();
        rotate.Disable();
    }

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        move = movew.ReadValue<Vector2>() * (speed * Time.deltaTime);

        transform.Translate(move.x, 0, move.y);
    }

    private void Rotate()
    {
        look = rotate.ReadValue<Vector2>();

        x += look.x;
        y -= look.y;

        y = Mathf.Clamp(y, -85, 85);

        transform.localRotation = Quaternion.Euler(0, x, 0 * sens * Time.deltaTime);
        camHold.transform.localRotation = Quaternion.Euler(y, 0, 0 * sens * Time.deltaTime);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            rb.AddForce(jump * jumpHight, ForceMode.Impulse);
        }
        
    }

    public void Sprint(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            speed = sprint;
        }
    }

}
