using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class TransformComponentExtensions
    {
        public static Entity AddTransformComponent(this Entity entity, TransformComponent component)
        {
            World.Default.GetStash<TransformComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetTransformComponent(this Entity entity, TransformComponent component)
        {
            World.Default.GetStash<TransformComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveTransformComponent(this Entity entity)
        {
            World.Default.GetStash<TransformComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasTransformComponent(this Entity entity)
        {
            return World.Default.GetStash<TransformComponent>().Has(entity);
        }
        
        public static TransformComponent GetTransformComponent(this Entity entity)
        {
            return World.Default.GetStash<TransformComponent>().Get(entity);
        }
    }
}