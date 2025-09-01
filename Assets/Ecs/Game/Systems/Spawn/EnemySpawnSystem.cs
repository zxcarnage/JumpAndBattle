using Ecs.Game.Components.Roads;
using Scellecs.Morpeh;

namespace Ecs.Game.Systems.Spawn
{

    public sealed class EnemySpawnSystem : ISystem
    {
        private Filter _roadFilter;
        
        public World World { get; set; }

        public void OnAwake()
        {
            _roadFilter = World.Filter
                .With<SpawnNodeComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
        }

        public void Dispose()
        {
        }
    }
}