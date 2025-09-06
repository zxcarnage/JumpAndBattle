using Game.Views.Enemy;
using Utils.Enemy;

namespace Game.Services.Pool.Enemy
{
    public interface IEnemyPool
    {
        EnemyView SpawnEnemy(EEnemyType enemyType);
        void DespawnEnemy(EEnemyType enemyType, EnemyView enemy);
    }
}