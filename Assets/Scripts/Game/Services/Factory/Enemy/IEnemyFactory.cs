using Game.Views.Enemy;
using UnityEngine;
using Utils.Enemy;
using Utils.SpawnNode;

namespace Game.Services.Factory.Enemy
{
    public interface IEnemyFactory
    {
        EnemyView CreateEnemy(EEnemyType enemyType, SpawnNodeData nodeData);
    }
}