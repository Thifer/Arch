using UnityEngine;


public sealed class AnimatorCharacter2D : MonoBehaviour
{
    private Animator _animator;
    private Character2D _character2D;
    private static readonly int _animatorRunningSpeed = Animator.StringToHash("RunningSpeed");
    private static readonly int _animatorJumpTrigger = Animator.StringToHash("Jump");  
    private static readonly int _fireDisable = Animator.StringToHash("FireDisable");
    private static readonly int _fireEnable = Animator.StringToHash("FireEnable");

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _character2D = GetComponent<Character2D>();
    }

    private void OnEnable()
    {
        _character2D.Jump += Character2DOnJump;
        _character2D.FireDisable += Character2DOnFireDisable;
        _character2D.FireEnable += Character2DOnFireEnable;
        _character2D.RunningSpeed += Character2DOnRunningSpeed;
    }

    private void OnDisable()
    {
        _character2D.Jump -= Character2DOnJump;
        _character2D.FireDisable -= Character2DOnFireDisable;
        _character2D.FireEnable -= Character2DOnFireEnable;
        _character2D.RunningSpeed -= Character2DOnRunningSpeed;
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