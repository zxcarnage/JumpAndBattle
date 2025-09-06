using Ecs.Game.Components.Character;
using Ecs.Game.Components.Enemy;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using UnityEngine;
using Utils;
using Utils.DebugUtil;
using Utils.Providers.GameField;

namespace Ecs.Game.Systems.BossFight
{
    public sealed class BossFightSystem : ISystem
    {
        private readonly IGameFieldProvider _gameFieldProvider;
        private Filter _playerInFightFilter;
        private Filter _bossFilter;
        
        public World World { get; set; }

        public BossFightSystem(
            IGameFieldProvider gameFieldProvider    
        )
        {
            _gameFieldProvider = gameFieldProvider;
        }

        public void OnAwake()
        {
            _playerInFightFilter = World.Filter
                .With<EnableTapShootingComponent>()
                .Build();
            
            _bossFilter = World.Filter
                .With<BossEnemyComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var player in _playerInFightFilter)
            {
                TryShoot();
            }

            return;

            void TryShoot() //TODO: ONLY PROTOTYPE FIGHTING
            {
                if (!UnityEngine.Input.GetMouseButton(0))
                    return;

                var ray = _gameFieldProvider.GameField.OutputCamera.ScreenPointToRay(UnityEngine.Input.mousePosition);

                if (!Physics.Raycast(ray, out var hit))
                    return;
                
                var bossEntity = FindEntityByCollider(hit.collider);

                if (bossEntity == null)
                    return;

                bossEntity!.Value.SetDeathComponent(new DeathComponent());
            }
        }
        
        private Entity? FindEntityByCollider(Collider hitCollider)
        {
            foreach (var bossEntity in _bossFilter)
            {
                var bossCollider = bossEntity.GetColliderComponent().Value;

                if (hitCollider == bossCollider)
                    return bossEntity;
            }
            
            return null;
        }


        public void Dispose()
        {
        }
    }
}