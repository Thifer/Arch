using UnityEngine;


public sealed class PlayerHP : BaseInteracteble
{
    [SerializeField] private float _hp;

    public override void SetValue(float value)
    {
        _hp += value; // сделать доп проверки
    }
}
