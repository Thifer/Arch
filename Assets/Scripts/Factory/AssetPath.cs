using System.Collections.Generic;

namespace DefaultNamespace
{
    public static class AssetPath
    {
        public static readonly Dictionary<EnemyType, string> Enemies = new Dictionary<EnemyType, string>
        {
            {EnemyType.Small, "Prefabs/Enemies/Prefabs_Enemies_SmallEnemy"},
            {EnemyType.CircleEnemy , "Prefab/Enemies/CircleEnemy" },
            {EnemyType.RectangleEnemy , "Prefabs/Enemies/RectangleEnemy" },
            {EnemyType.SquareEnemy , "Prefabs/Enemies/SquareEnemy" }

        };
    }
}
