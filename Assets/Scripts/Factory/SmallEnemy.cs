using UnityEngine;

namespace DefaultNamespace
{
    public sealed class SmallEnemy : Enemy
    {
        public override void Fire()
        {
            Debug.Log(nameof(SmallEnemy));
        }
    }
}
