using Scellecs.Morpeh;
using Ecs.Game.Components.Enemy;

namespace Ecs.Generated.Components
{
    public static class EnemyComponentExtensions
    {
        public static Entity AddEnemyComponent(this Entity entity, EnemyComponent component)
        {
            World.Default.GetStash<EnemyComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetEnemyComponent(this Entity entity, EnemyComponent component)
        {
            World.Default.GetStash<EnemyComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveEnemyComponent(this Entity entity)
        {
            World.Default.GetStash<EnemyComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasEnemyComponent(this Entity entity)
        {
            return World.Default.GetStash<EnemyComponent>().Has(entity);
        }
        
        public static EnemyComponent GetEnemyComponent(this Entity entity)
        {
            return World.Default.GetStash<EnemyComponent>().Get(entity);
        }
    }
}