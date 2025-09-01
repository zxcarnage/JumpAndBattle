using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Ecs.Game.Systems.Input
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public sealed class KeyboardInputSystem : ISystem
    {
        private readonly PlayerInputAction _inputAction;

        private Filter _playerFilter;

        public World World { get; set; }

        public KeyboardInputSystem(
            PlayerInputAction inputAction
        )
        {
            _inputAction = inputAction;
        }

        public void OnAwake()
        {
            _playerFilter = World.Filter
                .With<PlayerComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            var playerEntity = _playerFilter.First();
            HandleMovementInput();

            return;

            void HandleMovementInput()
            {
                var movementInputDirection = Vector2.ClampMagnitude(_inputAction.Keyboard.WASDMovement.ReadValue<Vector2>(), 1f);

                var movementVector = new Vector3(movementInputDirection.x, 0f, movementInputDirection.y);

                playerEntity.SetMoveDirectionComponent(new MoveDirectionComponent { Value = movementVector, });
            }
        }

        public void Dispose()
        {
        }
    }
}