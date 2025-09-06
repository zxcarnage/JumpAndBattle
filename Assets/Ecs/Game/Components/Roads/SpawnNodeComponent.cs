using System;
using Ecs.Core.Utils.CodeGenerator;
using Scellecs.Morpeh;
using Utils.SpawnNode;

namespace Ecs.Game.Components.Roads
{
    [Serializable]
    [Generate]
    public struct SpawnNodeComponent : IComponent
    {
        public SpawnNode Value;
    }
}