using UnityEngine;


public abstract class Ammunition : MonoBehaviour
{
    [SerializeField] private float damage;
    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.TryGetComponent<IHaveHP>(out var target)&& !other.collider.CompareTag(TagManager.GetTag(TagType.Player)))
        {
            target.SetValue(damage);
        }
    }
}