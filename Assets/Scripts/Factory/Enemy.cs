using System;
using System.Collections;
using UnityEngine;


namespace DefaultNamespace
{
    public abstract class Enemy : MonoBehaviour
    {
        public Hp _hp;

        // public static SmallEnemy CreateSmallEnemy(float hp)
        // {
        //     var enemy = Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.Small]));
        //
        //     enemy._hp = hp;
        //
        //     return enemy;
        // }

        public void SetHP(Hp hp)
        {
            _hp = hp;
        }

        public abstract void Fire();

        private IEnumerator Start()
        {
            while (true)
            {
                Fire();
                yield return new WaitForSeconds(3.0f);
            }
        }
    }
}
