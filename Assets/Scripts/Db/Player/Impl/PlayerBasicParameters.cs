using UnityEngine;

namespace Db.Player.Impl
{
    public class PlayerBasicParameters : ScriptableObject, IPlayerBasicParameters
    {
        [field: SerializeField]
        public float Speed { get; private set; }
    }
}