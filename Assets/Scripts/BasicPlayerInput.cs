using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class BasicPlayerInput : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Transform _transform;
    private PlayerInput _playerInput;
    private PlayerControls _playerControls;
    private BasicSpearControls _spearControls;
    
    public int maxJumps = 2;
    public float movementSpeed = 5f;
    
    private int _jumpCount;
    private Vector3 previousPosition;
    
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
        _transform = GetComponent<Transform>();
        _playerControls = new PlayerControls();
        _playerControls.Player.Enable();
        _playerControls.Player.Jump.performed += Jump;
        _playerControls.Player.Pause.performed += Pause;
        _playerControls.UserInterface.Unpause.performed += Unpause;
        _spearControls = GameObject.Find("Spear").GetComponent<BasicSpearControls>();
        _jumpCount = maxJumps;
    }

    private void Start()
    {
        gameObject.tag = "player"; 
        previousPosition = _transform.position;
    }

    public void FixedUpdate()
    {
        
        if (!_spearControls.isPiercing)
        {
            Movement(_playerControls.Player.Movement.ReadValue<Vector2>());
        }
        else
        {
            _transform.position = previousPosition;
        }
    }

    public void Update()
    {
        
    }

    private void Movement(Vector2 movementValue)
    {
        // Debug.Log("Movement!");
        _rigidbody2D.AddForce(movementValue * movementSpeed, ForceMode2D.Force);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && _jumpCount > 0)
        {
            Debug.Log("Jumped!");
            _rigidbody2D.AddForce(Vector2.up * 8f, ForceMode2D.Impulse);
            _jumpCount -= 1;
        }
    }

    public void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("ground"))
        {
            _jumpCount = maxJumps;
        }
    }

    public void Pause(InputAction.CallbackContext context)
    {
        Debug.Log("Player Paused");
        _playerControls.UserInterface.Enable();
        _playerControls.Player.Disable();
    }

    public void Unpause(InputAction.CallbackContext context)
    {
        Debug.Log("Player Unpaused");
        _playerControls.Player.Enable();
        _playerControls.UserInterface.Disable();
    }
    
}
