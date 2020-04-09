using UnityEngine;

public sealed class Laser : Weapon, ICancelFire
{
    private LaserAmmunitiom TempAmmo;

    public override void Fire()
    {
        Debug.Log(_isReady);
        if(!_isReady) return;
        if (_isReady)
        {
            var direction = -_barrel.right * transform.localScale.x;
            if (_ammunition is LaserAmmunitiom ammunitiom)
            {
                TempAmmo = Instantiate(ammunitiom, _barrel.position, _barrel.rotation);
                TempAmmo.SetLineRenderer(_barrel.transform, direction);
            }
        }

        _isReady = false;
    }

    public void EndFire()
    {
        Debug.Log("destroy");
        Destroy(TempAmmo.gameObject);
        _isReady = true;
    }
}
