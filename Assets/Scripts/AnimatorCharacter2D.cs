using System;
using UnityEngine;


public sealed class AnimatorCharacter2D : MonoBehaviour
{
    [SerializeField]private Animator _animator;
    [SerializeField]private Character2D _character2D;
    private CharController _charController;
    private static readonly int _animatorRunningSpeed = Animator.StringToHash("RunningSpeed");
    private static readonly int _animatorJumpTrigger = Animator.StringToHash("Jump");  
    private static readonly int _fireDisable = Animator.StringToHash("FireDisable");
    private static readonly int _fireEnable = Animator.StringToHash("FireEnable");

    private void Awake()
    {
        _charController = _character2D._charController;
    }

    private void OnEnable()
    {
        _charController.Jump += Character2DOnJump;
        _charController.FireDisable += Character2DOnFireDisable;
        _charController.FireEnable += Character2DOnFireEnable;
        _charController.RunningSpeed += Character2DOnRunningSpeed;
    }

    private void OnDisable()
    {
        _charController.Jump -= Character2DOnJump;
        _charController.FireDisable -= Character2DOnFireDisable;
        _charController.FireEnable -= Character2DOnFireEnable;
        _charController.RunningSpeed -= Character2DOnRunningSpeed;
    }

    private void Character2DOnRunningSpeed(float obj)
    {
        _animator.SetFloat(_animatorRunningSpeed, obj);
    }

    private void Character2DOnFireEnable()
    {
        _animator.SetTrigger(_fireEnable);
    }

    private void Character2DOnFireDisable()
    {
        _animator.SetTrigger(_fireDisable);
    }

    private void Character2DOnJump()
    {
        _animator.SetTrigger(_animatorJumpTrigger);
    }
}
