using UnityEngine;

public sealed class Bullet : Ammunition
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
         Destroy(gameObject);
    }
}