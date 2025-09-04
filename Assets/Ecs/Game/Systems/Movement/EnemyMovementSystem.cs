using Ecs.Game.Components.Enemy;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using UnityEngine;
using Utils.DebugUtil;

namespace Ecs.Game.Systems.Movement
{
    public sealed class EnemyMovementSystem : IFixedSystem
    {
        private Filter _enemyFilter;
        
        public World World { get; set; }

        public void OnAwake()
        {
            _enemyFilter = World.Filter
                .With<EnemyComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var enemy in _enemyFilter)
            {
                var enemyRigidbody = enemy.GetRigidbodyComponent().Value;
                var speed = enemy.GetSpeedComponent().Value;

                enemyRigidbody.velocity = new Vector3(-speed, enemyRigidbody.velocity.y, enemyRigidbody.velocity.z);
            }
        }

        public void Dispose()
        {
        }
    }
}