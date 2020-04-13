using UnityEngine;

namespace DefaultNamespace
{
    public sealed class BigEnemyFactory : ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.Big]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
