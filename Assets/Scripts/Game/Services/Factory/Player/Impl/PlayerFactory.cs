using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Game.Views.Player;
using Scellecs.Morpeh;
using UnityEngine;
using Zenject;

namespace Game.Services.Factory.Player.Impl
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly DiContainer _container;
        private readonly World _world;

        public PlayerFactory(
            World world,
            DiContainer container
        )
        {
            _world = world;
            _container = container;
        }

        public Entity CreatePlayer(GameObject prefab, Vector3 position, int maxHealth)
        {
            var playerView = _container.InstantiatePrefab(prefab)
                .GetComponent<PlayerView>();;

            var playerEntity = _world.CreateEntity();

            playerEntity.AddPlayerComponent(new PlayerComponent());

            playerEntity.SetColliderComponent(
                new ColliderComponent()
                {
                    Value = playerView.Collider,
                }
            );

            playerEntity.SetRigidbodyComponent(
                new RigidbodyComponent()
                {
                    Value = playerView.Rigidbody,
                }
            );

            playerEntity.SetTransformComponent(
                new TransformComponent()
                {
                    Value = playerView.transform,
                }
            );

            playerEntity.SetMaxHealthComponent(
                new MaxHealthComponent()
                {
                    Value = maxHealth,
                }
            );
            
            playerEntity.SetHealthComponent(
                new HealthComponent()
                {
                    Value = maxHealth,
                }
            );
            
            playerView.transform.position = position;

            return playerEntity;
        }
    }
}