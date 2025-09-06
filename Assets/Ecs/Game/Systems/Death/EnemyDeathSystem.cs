using Ecs.Game.Components.Character;
using Ecs.Game.Components.Enemy;
using Ecs.Generated.Components;
using Game.Services.Pool.Enemy;
using Scellecs.Morpeh;

namespace Ecs.Game.Systems.Death
{
    public sealed class EnemyDeathSystem : ISystem
    {
        private readonly IEnemyPool _enemyPool;
        private Filter _deadEnemyFilter;
        
        public World World { get; set; }

        public EnemyDeathSystem(
            IEnemyPool enemyPool    
        )
        {
            _enemyPool = enemyPool;
        }

        public void OnAwake()
        {
            _deadEnemyFilter = World.Filter
                .With<BossEnemyComponent>()
                .With<DeathComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var deadEnemyEntity in _deadEnemyFilter)
            {
                var bossType = deadEnemyEntity.GetEnemyTypeComponent().Value;
                var bossView = deadEnemyEntity.GetBossEnemyComponent().Value;
                _enemyPool.DespawnEnemy(bossType, bossView);
                World.RemoveEntity(deadEnemyEntity);
            }
        }

        public void Dispose()
        {
        }
    }
}