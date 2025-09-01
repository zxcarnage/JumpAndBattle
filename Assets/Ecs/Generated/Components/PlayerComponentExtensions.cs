using Scellecs.Morpeh;
using Ecs.Game.Components.Player;

namespace Ecs.Generated.Components
{
    public static class PlayerComponentExtensions
    {
        public static Entity AddPlayerComponent(this Entity entity, PlayerComponent component)
        {
            World.Default.GetStash<PlayerComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetPlayerComponent(this Entity entity, PlayerComponent component)
        {
            World.Default.GetStash<PlayerComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemovePlayerComponent(this Entity entity)
        {
            World.Default.GetStash<PlayerComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasPlayerComponent(this Entity entity)
        {
            return World.Default.GetStash<PlayerComponent>().Has(entity);
        }
        
        public static PlayerComponent GetPlayerComponent(this Entity entity)
        {
            return World.Default.GetStash<PlayerComponent>().Get(entity);
        }
    }
}