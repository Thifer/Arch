using System;
using UnityEngine;

public class CharController
{
    public event Action<float> RunningSpeed = delegate { };
    public event Action Jump = delegate { };
    public event Action FireDisable = delegate { };
    public event Action FireEnable = delegate { };
    private Gun SimpleGun;
    private Laser SimpleLaser;
    private float _acceleration = 0.0f;
    private float _maxSpeed = 0.0f;
    private float _jumpForce = 0.0f;
    private GameObject _character;
    private Rigidbody2D _controllerRigidbody;
    private Vector2 _movementInput;
    private bool _jumpInput;
    private Weapon _activeWeapon;
    private Transform _transform;

    private bool _isJumping;
    private bool _isFalling;
    private GunType _gun;

    public CharController(GameObject character,Rigidbody2D _rb, float acceleration, float maxSpeed, float jumpForce,Gun simpleGun,Laser simpleLaser)
    {
        _character = character;
        _controllerRigidbody = _rb;
        _acceleration = acceleration;
        _maxSpeed = maxSpeed;
        _jumpForce = jumpForce;
        _gun = GunType.Gun;
        SimpleGun = simpleGun;
        SimpleLaser = simpleLaser;
        _transform = character.transform;
    }
    
    
    private void UpdateVelocity()
    {
        var velocity = _controllerRigidbody.velocity;

        velocity += _movementInput * (_acceleration * Time.fixedDeltaTime);

        _movementInput = Vector2.zero;

        velocity.x = Mathf.Clamp(velocity.x, -_maxSpeed, _maxSpeed);

        _controllerRigidbody.velocity = velocity;

        var horizontalSpeedNormalized = Mathf.Abs(velocity.x) / _maxSpeed;
        RunningSpeed.Invoke(horizontalSpeedNormalized);

        // Play audio dz
    }

    public void Flip(float value)
    {
        Vector3 localScale = _transform.localScale;
        localScale.x = value;
        _transform.localScale = localScale;
    }

    private void UpdateJump()
    {
        if (_isJumping && _controllerRigidbody.velocity.y < 0)
        {
            _isFalling = true;
        }

        if (_jumpInput)
        {
            _controllerRigidbody.AddForce(new Vector2(0.0f, _jumpForce), ForceMode2D.Impulse);

            Jump.Invoke();

            _jumpInput = false;

            _isJumping = true;

            // Play audio
        }
        else if (_isJumping && _isFalling)
        {
            _isJumping = false;
            _isFalling = false;

            // Play audio
        }
    }

    public void OnUpdate()
    {
        var moveHorizontal = 0.0f;

        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1.0f;
            Flip(-1.0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1.0f;
            Flip(1.0f);
        }

        _movementInput = new Vector2(moveHorizontal, 0.0f);

        if (!_isJumping && Input.GetKeyDown(KeyCode.Space))
        {
            _jumpInput = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            FireEnable.Invoke();
            switch (_gun)
            {
                case GunType.Gun:
                    _activeWeapon = SimpleGun;
                    break;
                case GunType.Laser:
                    _activeWeapon = SimpleLaser;
                    break;
                default:
                    break;
            }
            _activeWeapon.Fire();
        }

        if (Input.GetMouseButtonUp(0))
        {
            FireDisable.Invoke();
            if (_activeWeapon is ICancelFire weapon)
            {
                weapon.EndFire();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            switch (_gun)
            {
                case GunType.Gun:
                    _gun = GunType.Laser;
                    break;
                case GunType.Laser:
                    _gun = GunType.Gun;
                    break;
                default: 
                    break;

            }
        }
    }

    public void OnFixUpdate()
    {
        UpdateVelocity();
        UpdateJump();
    }
}
