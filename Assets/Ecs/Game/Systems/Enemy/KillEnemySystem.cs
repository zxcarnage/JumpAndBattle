using Db.Enemy;
using Ecs.Game.Components.Enemy;
using Ecs.Generated.Components;
using Game.Services.Pool.Enemy;
using Scellecs.Morpeh;
using UnityEngine;
using Utils.DebugUtil;
using DebugUtility = Utils.DebugUtil.DebugUtility;

namespace Ecs.Game.Systems.Enemy
{
    public sealed class KillEnemySystem : ISystem
    {
        private readonly IEnemyParameters _enemyParameters;
        private readonly IEnemyPool _enemyPool;

        private Filter _enemyFilter;
        
        public World World { get; set; }

        public KillEnemySystem(
            IEnemyPool enemyPool,
            IEnemyParameters enemyParameters
        )
        {
            _enemyPool = enemyPool;
            _enemyParameters = enemyParameters;
        }

        public void OnAwake()
        {
            _enemyFilter = World.Filter
                .With<EnemyComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var enemyEntity in _enemyFilter)
            {
                var enemyPosition = enemyEntity.GetTransformComponent().Value.position;
                var enemyStartPosition = enemyEntity.GetEnemyStartPosition().Value;
                var maxDistance = _enemyParameters.MaxPassedDistance;
                
                if(Vector3.Distance(enemyPosition, enemyStartPosition) < maxDistance)
                    continue;
                
                var enemyType = enemyEntity.GetEnemyTypeComponent().Value;
                var enemyView = enemyEntity.GetEnemyComponent().Value;
                
                _enemyPool.DespawnEnemy(enemyType, enemyView);
                World.RemoveEntity(enemyEntity);
            }
        }

        public void Dispose()
        {
        }
    }
}