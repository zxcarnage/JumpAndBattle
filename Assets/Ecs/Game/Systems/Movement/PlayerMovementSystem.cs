using Db.Player;
using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Ecs.Game.Systems.Movement
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public sealed class PlayerMovementSystem : IFixedSystem
    {
        private readonly IPlayerBasicParameters _playerBasicParameters;
        
        private Filter _playerFilter;
        
        public World World { get; set; }

        public PlayerMovementSystem(
            IPlayerBasicParameters playerBasicParameters
        )
        {
            _playerBasicParameters = playerBasicParameters;
        }
        
        public void OnAwake()
        {
            _playerFilter = World.Filter
                .With<PlayerComponent>()
                .With<MoveDirectionComponent>()
                .With<RigidbodyComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            var playerEntity = _playerFilter.First();
            HandleMovement();

            return;

            void HandleMovement()
            {
                if (playerEntity.HasMovementBlockedComponent())
                    return;
                
                var direction = playerEntity.GetMoveDirectionComponent().Value;
                var rigidbody = playerEntity.GetRigidbodyComponent().Value;
                var transform = playerEntity.GetTransformComponent().Value;
                
                var localDirection = new Vector3(direction.x, 0f, direction.z);
                var worldDirection = transform.TransformDirection(localDirection);
                var currentYVelocity = rigidbody.velocity.y;
                var speed = _playerBasicParameters.Speed;
                var targetVelocity = worldDirection * speed;
                targetVelocity.y = currentYVelocity;
                
                rigidbody.velocity = targetVelocity;
            }
        }

        public void Dispose()
        {
        }
    }
}