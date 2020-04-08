using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected Transform _barrel;
    [SerializeField] protected Ammunition _ammunition;
    [SerializeField] protected float _rechergeTime = 0.2f;
    protected bool _isReady = true;
    // AudioService

    protected virtual void Awake()
    {
        // AudioServes = ....
    }

    public abstract void Fire();

    protected void ReadyShoot()
    {
        _isReady = true;
    }
}