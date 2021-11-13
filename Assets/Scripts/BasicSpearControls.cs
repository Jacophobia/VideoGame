using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class BasicSpearControls : MonoBehaviour
{
    private Transform _transform;
    private SpearControls _spearControls;
    private BoxCollider2D _boxCollider;
    private SpearHeadControls _spearhead;
    private GameObject _player;
    private Transform _playerTransform;
        
    public bool isPiercing = false;
    public int range = 1;

    private Vector2 previousStabValue;
    private float previousAngle = 0.0f;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _spearControls = new SpearControls();
        _boxCollider = GetComponent<BoxCollider2D>();

        _spearControls.Spear.Pause.performed += Pause;
        _spearControls.UserInterface.Unpause.performed += Unpause;
        
        _spearControls.Spear.Enable();
    }

    public void Start()
    {
        previousStabValue = _spearControls.Spear.Stab.ReadValue<Vector2>();
        // _spearhead = GameObject.FindGameObjectWithTag("spearhead").GetComponent<SpearHeadControls>();
        // Debug.Log(GameObject.FindGameObjectWithTag("spearhead"));
    }

    private void FixedUpdate()
    {
        PointSpear(_spearControls.Spear.Stab.ReadValue<Vector2>());
    }

    private void Update()
    {
        // isPiercing = _spearhead.isPiercing;
    }

    public void PointSpear(Vector2 stabValue)
    {
        float yManipulator = (float) Math.Floor(stabValue.y);
        float fullCircle = yManipulator * 2;
        float semiCircle = yManipulator * -180;
        float angle;
        if (!isPiercing)
        {
            angle = Vector2.Angle(new Vector2(1.0f + fullCircle, 0.0f), stabValue) + semiCircle;
        }
        else
        {
            angle = previousAngle;
        }
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.position += new Vector3((stabValue.x - previousStabValue.x) * range, (stabValue.y - previousStabValue.y) * range, 0.0f);
        previousStabValue = stabValue;
        previousAngle = angle;
    }

    public void Pause(InputAction.CallbackContext context)
    {
        Debug.Log("Spear Paused");
        _spearControls.UserInterface.Enable();
        _spearControls.Spear.Disable();
    }

    public void Unpause(InputAction.CallbackContext context)
    {
        Debug.Log("Spear Unpaused");
        _spearControls.Spear.Enable();
        _spearControls.UserInterface.Disable();
    }
}
