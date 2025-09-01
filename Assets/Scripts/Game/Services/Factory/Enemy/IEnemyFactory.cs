using Game.Views.Enemy;
using UnityEngine;
using Utils.Enemy;

namespace Game.Services.Factory.Enemy
{
    public interface IEnemyFactory
    {
        EnemyView CreateEnemy(EEnemyType enemyType, Vector3 position);
    }
}