using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;
    private Vector2 velocity;
    PlayerInputs inputs;
    Vector2 moveInput;
    private void Awake()
    {
        inputs = new PlayerInputs();
        inputs.Gameplay.Movement.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputs.Gameplay.Movement.canceled += ctx => moveInput = Vector2.zero;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity*Time.deltaTime);
    }

    void OnEnable()
    {
        inputs.Gameplay.Enable();
    }

    void OnDisable()
    {
        inputs.Gameplay.Disable();
    }
}
