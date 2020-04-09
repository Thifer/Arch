using System.CodeDom;
using UnityEngine;


public sealed class Box : BaseInteracteble
{
    public override void SetValue(float value)
    {
        hp += value;
        if (hp <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}