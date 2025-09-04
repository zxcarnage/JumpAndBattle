using Scellecs.Morpeh;
using Ecs.Game.Components.Enemy;

namespace Ecs.Generated.Components
{
    public static class EnemyTypeComponentExtensions
    {
        public static Entity AddEnemyTypeComponent(this Entity entity, EnemyTypeComponent component)
        {
            World.Default.GetStash<EnemyTypeComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetEnemyTypeComponent(this Entity entity, EnemyTypeComponent component)
        {
            World.Default.GetStash<EnemyTypeComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveEnemyTypeComponent(this Entity entity)
        {
            World.Default.GetStash<EnemyTypeComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasEnemyTypeComponent(this Entity entity)
        {
            return World.Default.GetStash<EnemyTypeComponent>().Has(entity);
        }
        
        public static EnemyTypeComponent GetEnemyTypeComponent(this Entity entity)
        {
            return World.Default.GetStash<EnemyTypeComponent>().Get(entity);
        }
    }
}