using UnityEngine;

namespace DefaultNamespace
{
    public class SqareEnemyFactroty : ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.SquareEnemy]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
