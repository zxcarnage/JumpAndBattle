using Scellecs.Morpeh;
using Ecs.Game.Components.Character;
using Ecs.Game.Components.Enemy;
using Ecs.Game.Components.Player;
using Ecs.Game.Components.Roads;
using Ecs.Game.Components.Timer;

namespace Ecs.Generated.Components
{
    public static class ComponentsExtensions
    {
        private static World _world;

        public static void Build(World world)
        {
            _world = world;
        }

        public static Entity AddBossEnemyComponent(this Entity entity, BossEnemyComponent component)
        {
            _world.GetStash<BossEnemyComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetBossEnemyComponent(this Entity entity, BossEnemyComponent component)
        {
            _world.GetStash<BossEnemyComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveBossEnemyComponent(this Entity entity)
        {
            _world.GetStash<BossEnemyComponent>().Remove(entity);
            return entity;
        }

        public static bool HasBossEnemyComponent(this Entity entity)
        {
            return _world.GetStash<BossEnemyComponent>().Has(entity);
        }

        public static BossEnemyComponent GetBossEnemyComponent(this Entity entity)
        {
            return _world.GetStash<BossEnemyComponent>().Get(entity);
        }

        public static Entity AddColliderComponent(this Entity entity, ColliderComponent component)
        {
            _world.GetStash<ColliderComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetColliderComponent(this Entity entity, ColliderComponent component)
        {
            _world.GetStash<ColliderComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveColliderComponent(this Entity entity)
        {
            _world.GetStash<ColliderComponent>().Remove(entity);
            return entity;
        }

        public static bool HasColliderComponent(this Entity entity)
        {
            return _world.GetStash<ColliderComponent>().Has(entity);
        }

        public static ColliderComponent GetColliderComponent(this Entity entity)
        {
            return _world.GetStash<ColliderComponent>().Get(entity);
        }

        public static Entity AddDeathComponent(this Entity entity, DeathComponent component)
        {
            _world.GetStash<DeathComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetDeathComponent(this Entity entity, DeathComponent component)
        {
            _world.GetStash<DeathComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveDeathComponent(this Entity entity)
        {
            _world.GetStash<DeathComponent>().Remove(entity);
            return entity;
        }

        public static bool HasDeathComponent(this Entity entity)
        {
            return _world.GetStash<DeathComponent>().Has(entity);
        }

        public static DeathComponent GetDeathComponent(this Entity entity)
        {
            return _world.GetStash<DeathComponent>().Get(entity);
        }

        public static Entity AddEnableTapShootingComponent(this Entity entity, EnableTapShootingComponent component)
        {
            _world.GetStash<EnableTapShootingComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetEnableTapShootingComponent(this Entity entity, EnableTapShootingComponent component)
        {
            _world.GetStash<EnableTapShootingComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveEnableTapShootingComponent(this Entity entity)
        {
            _world.GetStash<EnableTapShootingComponent>().Remove(entity);
            return entity;
        }

        public static bool HasEnableTapShootingComponent(this Entity entity)
        {
            return _world.GetStash<EnableTapShootingComponent>().Has(entity);
        }

        public static EnableTapShootingComponent GetEnableTapShootingComponent(this Entity entity)
        {
            return _world.GetStash<EnableTapShootingComponent>().Get(entity);
        }

        public static Entity AddEnemyComponent(this Entity entity, EnemyComponent component)
        {
            _world.GetStash<EnemyComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetEnemyComponent(this Entity entity, EnemyComponent component)
        {
            _world.GetStash<EnemyComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveEnemyComponent(this Entity entity)
        {
            _world.GetStash<EnemyComponent>().Remove(entity);
            return entity;
        }

        public static bool HasEnemyComponent(this Entity entity)
        {
            return _world.GetStash<EnemyComponent>().Has(entity);
        }

        public static EnemyComponent GetEnemyComponent(this Entity entity)
        {
            return _world.GetStash<EnemyComponent>().Get(entity);
        }

        public static Entity AddEnemyStartPosition(this Entity entity, EnemyStartPosition component)
        {
            _world.GetStash<EnemyStartPosition>().Add(entity, component);
            return entity;
        }

        public static Entity SetEnemyStartPosition(this Entity entity, EnemyStartPosition component)
        {
            _world.GetStash<EnemyStartPosition>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveEnemyStartPosition(this Entity entity)
        {
            _world.GetStash<EnemyStartPosition>().Remove(entity);
            return entity;
        }

        public static bool HasEnemyStartPosition(this Entity entity)
        {
            return _world.GetStash<EnemyStartPosition>().Has(entity);
        }

        public static EnemyStartPosition GetEnemyStartPosition(this Entity entity)
        {
            return _world.GetStash<EnemyStartPosition>().Get(entity);
        }

        public static Entity AddEnemyTypeComponent(this Entity entity, EnemyTypeComponent component)
        {
            _world.GetStash<EnemyTypeComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetEnemyTypeComponent(this Entity entity, EnemyTypeComponent component)
        {
            _world.GetStash<EnemyTypeComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveEnemyTypeComponent(this Entity entity)
        {
            _world.GetStash<EnemyTypeComponent>().Remove(entity);
            return entity;
        }

        public static bool HasEnemyTypeComponent(this Entity entity)
        {
            return _world.GetStash<EnemyTypeComponent>().Has(entity);
        }

        public static EnemyTypeComponent GetEnemyTypeComponent(this Entity entity)
        {
            return _world.GetStash<EnemyTypeComponent>().Get(entity);
        }

        public static Entity AddHealthComponent(this Entity entity, HealthComponent component)
        {
            _world.GetStash<HealthComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetHealthComponent(this Entity entity, HealthComponent component)
        {
            _world.GetStash<HealthComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveHealthComponent(this Entity entity)
        {
            _world.GetStash<HealthComponent>().Remove(entity);
            return entity;
        }

        public static bool HasHealthComponent(this Entity entity)
        {
            return _world.GetStash<HealthComponent>().Has(entity);
        }

        public static HealthComponent GetHealthComponent(this Entity entity)
        {
            return _world.GetStash<HealthComponent>().Get(entity);
        }

        public static Entity AddHitComponent(this Entity entity, HitComponent component)
        {
            _world.GetStash<HitComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetHitComponent(this Entity entity, HitComponent component)
        {
            _world.GetStash<HitComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveHitComponent(this Entity entity)
        {
            _world.GetStash<HitComponent>().Remove(entity);
            return entity;
        }

        public static bool HasHitComponent(this Entity entity)
        {
            return _world.GetStash<HitComponent>().Has(entity);
        }

        public static HitComponent GetHitComponent(this Entity entity)
        {
            return _world.GetStash<HitComponent>().Get(entity);
        }

        public static Entity AddMaxHealthComponent(this Entity entity, MaxHealthComponent component)
        {
            _world.GetStash<MaxHealthComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetMaxHealthComponent(this Entity entity, MaxHealthComponent component)
        {
            _world.GetStash<MaxHealthComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveMaxHealthComponent(this Entity entity)
        {
            _world.GetStash<MaxHealthComponent>().Remove(entity);
            return entity;
        }

        public static bool HasMaxHealthComponent(this Entity entity)
        {
            return _world.GetStash<MaxHealthComponent>().Has(entity);
        }

        public static MaxHealthComponent GetMaxHealthComponent(this Entity entity)
        {
            return _world.GetStash<MaxHealthComponent>().Get(entity);
        }

        public static Entity AddMoveDirectionComponent(this Entity entity, MoveDirectionComponent component)
        {
            _world.GetStash<MoveDirectionComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetMoveDirectionComponent(this Entity entity, MoveDirectionComponent component)
        {
            _world.GetStash<MoveDirectionComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveMoveDirectionComponent(this Entity entity)
        {
            _world.GetStash<MoveDirectionComponent>().Remove(entity);
            return entity;
        }

        public static bool HasMoveDirectionComponent(this Entity entity)
        {
            return _world.GetStash<MoveDirectionComponent>().Has(entity);
        }

        public static MoveDirectionComponent GetMoveDirectionComponent(this Entity entity)
        {
            return _world.GetStash<MoveDirectionComponent>().Get(entity);
        }

        public static Entity AddMovementBlockedComponent(this Entity entity, MovementBlockedComponent component)
        {
            _world.GetStash<MovementBlockedComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetMovementBlockedComponent(this Entity entity, MovementBlockedComponent component)
        {
            _world.GetStash<MovementBlockedComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveMovementBlockedComponent(this Entity entity)
        {
            _world.GetStash<MovementBlockedComponent>().Remove(entity);
            return entity;
        }

        public static bool HasMovementBlockedComponent(this Entity entity)
        {
            return _world.GetStash<MovementBlockedComponent>().Has(entity);
        }

        public static MovementBlockedComponent GetMovementBlockedComponent(this Entity entity)
        {
            return _world.GetStash<MovementBlockedComponent>().Get(entity);
        }

        public static Entity AddPlayerComponent(this Entity entity, PlayerComponent component)
        {
            _world.GetStash<PlayerComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetPlayerComponent(this Entity entity, PlayerComponent component)
        {
            _world.GetStash<PlayerComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemovePlayerComponent(this Entity entity)
        {
            _world.GetStash<PlayerComponent>().Remove(entity);
            return entity;
        }

        public static bool HasPlayerComponent(this Entity entity)
        {
            return _world.GetStash<PlayerComponent>().Has(entity);
        }

        public static PlayerComponent GetPlayerComponent(this Entity entity)
        {
            return _world.GetStash<PlayerComponent>().Get(entity);
        }

        public static Entity AddRigidbodyComponent(this Entity entity, RigidbodyComponent component)
        {
            _world.GetStash<RigidbodyComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetRigidbodyComponent(this Entity entity, RigidbodyComponent component)
        {
            _world.GetStash<RigidbodyComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveRigidbodyComponent(this Entity entity)
        {
            _world.GetStash<RigidbodyComponent>().Remove(entity);
            return entity;
        }

        public static bool HasRigidbodyComponent(this Entity entity)
        {
            return _world.GetStash<RigidbodyComponent>().Has(entity);
        }

        public static RigidbodyComponent GetRigidbodyComponent(this Entity entity)
        {
            return _world.GetStash<RigidbodyComponent>().Get(entity);
        }

        public static Entity AddSpawnNodeComponent(this Entity entity, SpawnNodeComponent component)
        {
            _world.GetStash<SpawnNodeComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetSpawnNodeComponent(this Entity entity, SpawnNodeComponent component)
        {
            _world.GetStash<SpawnNodeComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveSpawnNodeComponent(this Entity entity)
        {
            _world.GetStash<SpawnNodeComponent>().Remove(entity);
            return entity;
        }

        public static bool HasSpawnNodeComponent(this Entity entity)
        {
            return _world.GetStash<SpawnNodeComponent>().Has(entity);
        }

        public static SpawnNodeComponent GetSpawnNodeComponent(this Entity entity)
        {
            return _world.GetStash<SpawnNodeComponent>().Get(entity);
        }

        public static Entity AddSpeedComponent(this Entity entity, SpeedComponent component)
        {
            _world.GetStash<SpeedComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetSpeedComponent(this Entity entity, SpeedComponent component)
        {
            _world.GetStash<SpeedComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveSpeedComponent(this Entity entity)
        {
            _world.GetStash<SpeedComponent>().Remove(entity);
            return entity;
        }

        public static bool HasSpeedComponent(this Entity entity)
        {
            return _world.GetStash<SpeedComponent>().Has(entity);
        }

        public static SpeedComponent GetSpeedComponent(this Entity entity)
        {
            return _world.GetStash<SpeedComponent>().Get(entity);
        }

        public static Entity AddTimerComponent(this Entity entity, TimerComponent component)
        {
            _world.GetStash<TimerComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetTimerComponent(this Entity entity, TimerComponent component)
        {
            _world.GetStash<TimerComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveTimerComponent(this Entity entity)
        {
            _world.GetStash<TimerComponent>().Remove(entity);
            return entity;
        }

        public static bool HasTimerComponent(this Entity entity)
        {
            return _world.GetStash<TimerComponent>().Has(entity);
        }

        public static TimerComponent GetTimerComponent(this Entity entity)
        {
            return _world.GetStash<TimerComponent>().Get(entity);
        }

        public static Entity AddTransformComponent(this Entity entity, TransformComponent component)
        {
            _world.GetStash<TransformComponent>().Add(entity, component);
            return entity;
        }

        public static Entity SetTransformComponent(this Entity entity, TransformComponent component)
        {
            _world.GetStash<TransformComponent>().Set(entity, component);
            return entity;
        }

        public static Entity RemoveTransformComponent(this Entity entity)
        {
            _world.GetStash<TransformComponent>().Remove(entity);
            return entity;
        }

        public static bool HasTransformComponent(this Entity entity)
        {
            return _world.GetStash<TransformComponent>().Has(entity);
        }

        public static TransformComponent GetTransformComponent(this Entity entity)
        {
            return _world.GetStash<TransformComponent>().Get(entity);
        }

    }
}
