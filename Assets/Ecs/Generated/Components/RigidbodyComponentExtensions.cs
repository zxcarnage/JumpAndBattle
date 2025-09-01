using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class RigidbodyComponentExtensions
    {
        public static Entity AddRigidbodyComponent(this Entity entity, RigidbodyComponent component)
        {
            World.Default.GetStash<RigidbodyComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetRigidbodyComponent(this Entity entity, RigidbodyComponent component)
        {
            World.Default.GetStash<RigidbodyComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveRigidbodyComponent(this Entity entity)
        {
            World.Default.GetStash<RigidbodyComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasRigidbodyComponent(this Entity entity)
        {
            return World.Default.GetStash<RigidbodyComponent>().Has(entity);
        }
        
        public static RigidbodyComponent GetRigidbodyComponent(this Entity entity)
        {
            return World.Default.GetStash<RigidbodyComponent>().Get(entity);
        }
    }
}