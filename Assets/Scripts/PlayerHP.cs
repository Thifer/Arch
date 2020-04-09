using UnityEngine;


public sealed class PlayerHP : BaseInteracteble
{
    [SerializeField] private float _hp;

    public override void SetValue(float value)
    {
        _hp -= value; // сделать доп проверки
        if (_hp <= 0)
        {
            Destroy(gameObject);//Аля смерть
        }
    }
}
