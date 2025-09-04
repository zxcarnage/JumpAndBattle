using Scellecs.Morpeh;
using Ecs.Game.Components.Timer;

namespace Ecs.Generated.Components
{
    public static class TimerComponentExtensions
    {
        public static Entity AddTimerComponent(this Entity entity, TimerComponent component)
        {
            World.Default.GetStash<TimerComponent>().Add(entity, component);
            return entity;
        }
        
        public static Entity SetTimerComponent(this Entity entity, TimerComponent component)
        {
            World.Default.GetStash<TimerComponent>().Set(entity, component);
            return entity;
        }
        
        public static Entity RemoveTimerComponent(this Entity entity)
        {
            World.Default.GetStash<TimerComponent>().Remove(entity);
            return entity;
        }
        
        public static bool HasTimerComponent(this Entity entity)
        {
            return World.Default.GetStash<TimerComponent>().Has(entity);
        }
        
        public static TimerComponent GetTimerComponent(this Entity entity)
        {
            return World.Default.GetStash<TimerComponent>().Get(entity);
        }
    }
}