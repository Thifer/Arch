using UnityEngine;


public sealed class Bullet : Ammunition
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        if (!collision.collider.CompareTag(TagManager.GetTag(TagType.Player)))
        {
            Destroy(gameObject);
        }
    }
}
