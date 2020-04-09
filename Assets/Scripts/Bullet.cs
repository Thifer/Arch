using UnityEngine;


public sealed class Bullet : Ammunition
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        SetDamage(collision.collider);
        if (!collision.collider.CompareTag(TagManager.GetTag(TagType.Player)))
        {
            Destroy(gameObject);
        }
    }
}
