using System;
using Ecs.Core.Utils.CodeGenerator;
using Scellecs.Morpeh;

namespace Ecs.Game.Components.Timer
{
    [Serializable]
    [Generate]
    public struct TimerComponent : IComponent
    {
        public float Value;
    }
}