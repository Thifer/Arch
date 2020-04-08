using UnityEngine;

public sealed class Gun : Weapon
{
    [SerializeField] private float _force = 999;

    protected override void Awake()
    {
        base.Awake();
        // sniper ... 
    }

    public override void Fire()
    {
        if (!_isReady) return;
        var direction = -_barrel.right * transform.localScale.x;
        var temAmmunition = Instantiate(_ammunition, _barrel.position, _barrel.rotation);
        temAmmunition.GetComponent<Rigidbody2D>().AddForce(direction * _force);
        _isReady = false;
        Invoke(nameof(ReadyShoot), _rechergeTime);
    }
}