using System;
using Ecs.Core.Utils.CodeGenerator;
using Scellecs.Morpeh;
using UnityEngine;

namespace Ecs.Game.Components.Enemy
{
    [Serializable]
    [Generate]
    public struct EnemyStartPosition : IComponent
    {
        public Vector3 Value;
    }
}