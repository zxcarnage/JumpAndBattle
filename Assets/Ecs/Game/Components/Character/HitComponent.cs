using Ecs.Core.Utils.CodeGenerator;
using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;

namespace Ecs.Game.Components.Character
{
    [System.Serializable]
    [Generate]
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public struct HitComponent : IComponent
    {
        public float Value;
    }
}