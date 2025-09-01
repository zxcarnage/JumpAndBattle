using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class MaxHealthComponentExtensions
    {
        public static Entity AddMaxHealthComponent(this Entity entity, MaxHealthComponent component)
        {
            World.Default.GetStash<MaxHealthComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetMaxHealthComponent(this Entity entity, MaxHealthComponent component)
        {
            World.Default.GetStash<MaxHealthComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveMaxHealthComponent(this Entity entity)
        {
            World.Default.GetStash<MaxHealthComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasMaxHealthComponent(this Entity entity)
        {
            return World.Default.GetStash<MaxHealthComponent>().Has(entity);
        }
        
        public static MaxHealthComponent GetMaxHealthComponent(this Entity entity)
        {
            return World.Default.GetStash<MaxHealthComponent>().Get(entity);
        }
    }
}