using System;
using UnityEngine;


public sealed class Character2D : MonoBehaviour
{
    [SerializeField] private Gun SimpleGun;
    [SerializeField] private Laser Laser;
    [SerializeField] private float _acceleration = 0.0f;
    [SerializeField] private float _maxSpeed = 0.0f;
    [SerializeField] private float _jumpForce = 0.0f;

    public CharController _charController;


    private void Awake()
    {
        _charController = new CharController(gameObject,GetComponent<Rigidbody2D>(),_acceleration,_maxSpeed,_jumpForce,SimpleGun,Laser);
    }

    private void Update()
    {
       _charController.OnUpdate();
    }

    private void FixedUpdate()
    {
         _charController.OnFixUpdate();
    }


}
