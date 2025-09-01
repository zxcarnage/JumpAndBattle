using Scellecs.Morpeh;
using Ecs.Game.Components.Character;

namespace Ecs.Generated.Components
{
    public static class MoveDirectionComponentExtensions
    {
        public static Entity AddMoveDirectionComponent(this Entity entity, MoveDirectionComponent component)
        {
            World.Default.GetStash<MoveDirectionComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetMoveDirectionComponent(this Entity entity, MoveDirectionComponent component)
        {
            World.Default.GetStash<MoveDirectionComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveMoveDirectionComponent(this Entity entity)
        {
            World.Default.GetStash<MoveDirectionComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasMoveDirectionComponent(this Entity entity)
        {
            return World.Default.GetStash<MoveDirectionComponent>().Has(entity);
        }
        
        public static MoveDirectionComponent GetMoveDirectionComponent(this Entity entity)
        {
            return World.Default.GetStash<MoveDirectionComponent>().Get(entity);
        }
    }
}