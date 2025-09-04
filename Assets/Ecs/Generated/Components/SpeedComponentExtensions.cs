using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class SpeedComponentExtensions
    {
        public static Entity AddSpeedComponent(this Entity entity, SpeedComponent component)
        {
            World.Default.GetStash<SpeedComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetSpeedComponent(this Entity entity, SpeedComponent component)
        {
            World.Default.GetStash<SpeedComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveSpeedComponent(this Entity entity)
        {
            World.Default.GetStash<SpeedComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasSpeedComponent(this Entity entity)
        {
            return World.Default.GetStash<SpeedComponent>().Has(entity);
        }
        
        public static SpeedComponent GetSpeedComponent(this Entity entity)
        {
            return World.Default.GetStash<SpeedComponent>().Get(entity);
        }
    }
}