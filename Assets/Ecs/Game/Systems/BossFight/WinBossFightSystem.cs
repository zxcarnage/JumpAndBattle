using Db.Base;
using Ecs.Game.Components.Enemy;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Game.Services.Factory.Chest;
using KoboldUi.Services.WindowsService;
using Scellecs.Morpeh;

namespace Ecs.Game.Systems.BossFight
{
    public sealed class WinBossFightSystem : ISystem
    {
        private readonly ILocalWindowsService _localWindowsService;
        private readonly ISimpleFactory _simpleFactory;
        private readonly IPrefabsBase _prefabsBase;

        private Filter _playerInFightFilter;
        private Filter _bossFilter;
        
        public World World { get; set; }

        public WinBossFightSystem(
            ILocalWindowsService localWindowsService,
            ISimpleFactory simpleFactory,
            IPrefabsBase prefabsBase
        )
        {
            _localWindowsService = localWindowsService;
            _simpleFactory = simpleFactory;
            _prefabsBase = prefabsBase;
        }

        public void OnAwake()
        {
            _playerInFightFilter = World.Filter
                .With<PlayerComponent>()
                .With<InBossFightComponent>()
                .Build();
            
            _bossFilter = World.Filter
                .With<BossEnemyComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var player in _playerInFightFilter)
            {
                if(_bossFilter.IsNotEmpty())
                    continue;
                
                _localWindowsService.CloseWindow();

                SpawnChest(player);
                player.RemoveInBossFightComponent();
            }

            return;

            void SpawnChest(Entity player)
            {
                var playerPosition = player.GetTransformComponent()
                    .Value.position;

                var treasureChestPosition = playerPosition;
                treasureChestPosition.z += 2f;

                var chestPrefab = _prefabsBase.Get("TreasureChest");
                
                _simpleFactory.Spawn(chestPrefab, treasureChestPosition);
            }
        }

        public void Dispose()
        {
        }
    }
}