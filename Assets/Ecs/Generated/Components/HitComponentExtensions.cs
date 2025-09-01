using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class HitComponentExtensions
    {
        public static Entity AddHitComponent(this Entity entity, HitComponent component)
        {
            World.Default.GetStash<HitComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetHitComponent(this Entity entity, HitComponent component)
        {
            World.Default.GetStash<HitComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveHitComponent(this Entity entity)
        {
            World.Default.GetStash<HitComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasHitComponent(this Entity entity)
        {
            return World.Default.GetStash<HitComponent>().Has(entity);
        }
        
        public static HitComponent GetHitComponent(this Entity entity)
        {
            return World.Default.GetStash<HitComponent>().Get(entity);
        }
    }
}