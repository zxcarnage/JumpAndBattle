using Ecs.Game.Components.Roads;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using Utils.Providers.GameField;
using Utils.SpawnNode;

namespace Ecs.Game.Systems.Initialize
{
    public sealed class RoadsInitializeSystem : IInitializer
    {
        private readonly IGameFieldProvider _gameFieldProvider;
        
        public World World { get; set; }

        public RoadsInitializeSystem(
            IGameFieldProvider gameFieldProvider    
        )
        {
            _gameFieldProvider = gameFieldProvider;
        }

        public void OnAwake()
        {
            SpawnNode previousNode = null;
            
            foreach (var data in _gameFieldProvider.GameField.EnemiesSpawnPoints)
            {
                var spawnNode = new SpawnNode(data);
                
                if(previousNode != null)
                    previousNode.NextNode = spawnNode;

                var roadEntity = World.CreateEntity();
                roadEntity.AddSpawnNodeComponent(new SpawnNodeComponent(){ Value = spawnNode, });
                
                previousNode = spawnNode;
            }
        }
        

        public void Dispose()
        {
            
        }
    }
}