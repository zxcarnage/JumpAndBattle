using System;
using Scellecs.Morpeh;

namespace Ecs.Game.Components.Timer
{
    [Serializable]
    public struct TimerComponent : IComponent
    {
        public float Value;
    }
}