using System;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class CreatorEnemies : MonoBehaviour
    {
        [SerializeField] private EnemyType _enemyType;
        [SerializeField] private float _hp;
        private ICreatorEnemy _creatorEnemy;
        private void Start()
        {
            // Enemy.CreateSmallEnemy(100.0f);

            switch (_enemyType)
            {
                case EnemyType.None:
                    break;
                case EnemyType.Small:
                    _creatorEnemy = new SmallEnemyFactory();
                    break;
                case EnemyType.Big:
                    break;
                case EnemyType.CircleEnemy:
                    _creatorEnemy = new CircleEnemyFactory();
                    break;
                case EnemyType.SquareEnemy:
                    _creatorEnemy = new SqareEnemyFactroty();
                    break;
                case EnemyType.RectangleEnemy:
                    _creatorEnemy = new RectangleEnemyFactrory();    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var enemy = _creatorEnemy.Create(new Hp());
            
            // var enemy = Instantiate(Resources.Load<SmallEnemy>(AssetPath.Enemies[EnemyType.Small]));
            enemy._hp.HP -= 5;
        }
        
    }
}
