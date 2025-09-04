using Scellecs.Morpeh;
using Ecs.Game.Components.Enemy;

namespace Ecs.Generated.Components
{
    public static class EnemyStartPositionExtensions
    {
        public static Entity AddEnemyStartPosition(this Entity entity, EnemyStartPosition component)
        {
            World.Default.GetStash<EnemyStartPosition>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetEnemyStartPosition(this Entity entity, EnemyStartPosition component)
        {
            World.Default.GetStash<EnemyStartPosition>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveEnemyStartPosition(this Entity entity)
        {
            World.Default.GetStash<EnemyStartPosition>().Remove(entity);
            return entity;
        }
        
        public static bool HasEnemyStartPosition(this Entity entity)
        {
            return World.Default.GetStash<EnemyStartPosition>().Has(entity);
        }
        
        public static EnemyStartPosition GetEnemyStartPosition(this Entity entity)
        {
            return World.Default.GetStash<EnemyStartPosition>().Get(entity);
        }
    }
}