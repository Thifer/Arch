public sealed class Laser : Weapon, ICancelFire
{
    public override void Fire()
    {
        throw new System.NotImplementedException();
    }

    public void EndFire()
    {
        throw new System.NotImplementedException();
    }
}