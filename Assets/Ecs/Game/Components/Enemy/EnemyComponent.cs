using System;
using Ecs.Core.Utils.CodeGenerator;
using Game.Views.Enemy;
using Scellecs.Morpeh;

namespace Ecs.Game.Components.Enemy
{
    [Serializable]
    [Generate]
    public struct EnemyComponent : IComponent
    {
        public EnemyView Value;
    }
}