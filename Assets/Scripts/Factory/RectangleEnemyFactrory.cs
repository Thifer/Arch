using UnityEngine;

namespace DefaultNamespace
{
    public class RectangleEnemyFactrory: ICreatorEnemy
    {
        public Enemy Create(Hp hp)
        {
            var enemy = Object.Instantiate(Resources.Load<RectangleEnemy>(AssetPath.Enemies[EnemyType.RectangleEnemy]));

            enemy.SetHP(hp);

            return enemy;
        }
    }
}
