using UnityEngine;


public sealed class Box : BaseInteracteble
{
    [SerializeField] private float _hp;

    private void OnEnable()
    {
        hp = _hp;
    }

    public override void SetValue(float value)
    {
        hp -= value;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}