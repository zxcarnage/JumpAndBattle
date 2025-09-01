using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class ColliderComponentExtensions
    {
        public static Entity AddColliderComponent(this Entity entity, ColliderComponent component)
        {
            World.Default.GetStash<ColliderComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetColliderComponent(this Entity entity, ColliderComponent component)
        {
            World.Default.GetStash<ColliderComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveColliderComponent(this Entity entity)
        {
            World.Default.GetStash<ColliderComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasColliderComponent(this Entity entity)
        {
            return World.Default.GetStash<ColliderComponent>().Has(entity);
        }
        
        public static ColliderComponent GetColliderComponent(this Entity entity)
        {
            return World.Default.GetStash<ColliderComponent>().Get(entity);
        }
    }
}