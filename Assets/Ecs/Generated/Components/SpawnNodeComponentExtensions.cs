using Scellecs.Morpeh;
using Ecs.Game.Components.Roads;

namespace Ecs.Generated.Components
{
    public static class SpawnNodeComponentExtensions
    {
        public static Entity AddSpawnNodeComponent(this Entity entity, SpawnNodeComponent component)
        {
            World.Default.GetStash<SpawnNodeComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetSpawnNodeComponent(this Entity entity, SpawnNodeComponent component)
        {
            World.Default.GetStash<SpawnNodeComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveSpawnNodeComponent(this Entity entity)
        {
            World.Default.GetStash<SpawnNodeComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasSpawnNodeComponent(this Entity entity)
        {
            return World.Default.GetStash<SpawnNodeComponent>().Has(entity);
        }
        
        public static SpawnNodeComponent GetSpawnNodeComponent(this Entity entity)
        {
            return World.Default.GetStash<SpawnNodeComponent>().Get(entity);
        }
    }
}