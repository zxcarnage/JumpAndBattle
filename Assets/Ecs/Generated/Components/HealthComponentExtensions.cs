using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class HealthComponentExtensions
    {
        public static Entity AddHealthComponent(this Entity entity, HealthComponent component)
        {
            World.Default.GetStash<HealthComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetHealthComponent(this Entity entity, HealthComponent component)
        {
            World.Default.GetStash<HealthComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveHealthComponent(this Entity entity)
        {
            World.Default.GetStash<HealthComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasHealthComponent(this Entity entity)
        {
            return World.Default.GetStash<HealthComponent>().Has(entity);
        }
        
        public static HealthComponent GetHealthComponent(this Entity entity)
        {
            return World.Default.GetStash<HealthComponent>().Get(entity);
        }
    }
}