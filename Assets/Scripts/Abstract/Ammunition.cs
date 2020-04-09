using UnityEngine;


public abstract class Ammunition : MonoBehaviour
{
    [SerializeField] protected float damage;
    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
        
    }

    protected void SetDamage(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent<IHaveHP>(out var target)&& !collider2D.CompareTag(TagManager.GetTag(TagType.Player)))
        {
            target.SetValue(damage);
        }
    }
}