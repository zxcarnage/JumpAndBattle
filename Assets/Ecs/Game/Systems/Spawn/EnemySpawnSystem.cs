using Ecs.Game.Components.Roads;
using Ecs.Game.Components.Timer;
using Ecs.Generated.Components;
using Game.Services.Factory.Enemy;
using Scellecs.Morpeh;
using Utils.DebugUtil;
using Utils.Enemy;

namespace Ecs.Game.Systems.Spawn
{
    public sealed class EnemySpawnSystem : ISystem
    {
        private readonly IEnemyFactory _enemyFactory;
        private Filter _roadFilter;
        
        public World World { get; set; }

        public EnemySpawnSystem(
            IEnemyFactory enemyFactory    
        )
        {
            _enemyFactory = enemyFactory;
        }

        public void OnAwake()
        {
            _roadFilter = World.Filter
                .With<SpawnNodeComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var road in _roadFilter)
            {
                var timer = road.GetTimerComponent().Value;
                var nodeData = road.GetSpawnNodeComponent().Value.SpawnNodeData;

                timer += deltaTime;

                if (timer < nodeData.Delay)
                {
                    road.SetTimerComponent(new TimerComponent() { Value = timer, });
                    continue;
                }

                _enemyFactory.CreateEnemy(EEnemyType.Common, nodeData);
                road.SetTimerComponent(new TimerComponent() { Value = 0f, });
            }
        }

        public void Dispose()
        {
        }
    }
}