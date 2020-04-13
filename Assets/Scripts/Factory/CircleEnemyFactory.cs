using UnityEngine;

namespace DefaultNamespace
{
    public class CircleEnemyFactory :ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<CircleEnemy>(AssetPath.Enemies[EnemyType.CircleEnemy]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
