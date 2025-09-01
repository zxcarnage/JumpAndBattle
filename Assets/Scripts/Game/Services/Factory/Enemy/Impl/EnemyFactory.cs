using Ecs.Game.Components.Character;
using Ecs.Game.Components.Enemy;
using Ecs.Generated.Components;
using Game.Services.Pool.Enemy;
using Game.Views.Enemy;
using Scellecs.Morpeh;
using UnityEngine;
using Utils;
using Utils.Enemy;

namespace Game.Services.Factory.Enemy.Impl
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly World _world;
        private readonly IEnemyPool _enemyPool;

        public EnemyFactory(
            World world,
            IEnemyPool enemyPool
        )
        {
            _world = world;
            _enemyPool = enemyPool;
        }
        
        public EnemyView CreateEnemy(EEnemyType enemyType, Vector3 position)
        {
            var enemyView = _enemyPool.SpawnEnemy(enemyType);
            enemyView.transform.position = position;
            
            var enemyEntity = _world.CreateEntity();

            enemyEntity.AddColliderComponent(
                new ColliderComponent()
                {
                    Value = enemyView.Collider,
                }
            );

            enemyEntity.AddEnemyComponent(new EnemyComponent());

            enemyEntity.AddTransformComponent(
                new TransformComponent()
                {
                    Value = enemyView.Transform,
                }
            );

            enemyEntity.AddRigidbodyComponent(
                new RigidbodyComponent()
                {
                    Value = enemyView.Rigidbody,
                }
            );

            enemyEntity.AddHealthComponent(
                new HealthComponent()
                {
                    Value = ConstValues.ENEMY_HEALTH,
                }
            );

            return enemyView;
        }
    }
}