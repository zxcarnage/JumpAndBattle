using System;
using Ecs.Core.Utils.CodeGenerator;
using Scellecs.Morpeh;
using Utils.Enemy;

namespace Ecs.Game.Components.Enemy
{
    [Serializable]
    [Generate]
    public struct EnemyTypeComponent : IComponent
    {
        public EEnemyType Value;
    }
}