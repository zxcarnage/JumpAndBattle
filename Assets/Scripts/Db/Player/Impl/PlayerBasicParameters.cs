using UnityEngine;

namespace Db.Player.Impl
{
    [CreateAssetMenu(menuName = "Settings/" + nameof(PlayerBasicParameters), fileName = nameof(PlayerBasicParameters))]
    public class PlayerBasicParameters : ScriptableObject, IPlayerBasicParameters
    {
        [field: SerializeField]
        public float Speed { get; private set; }
        
        
        [field: SerializeField]
        public int Health { get; private set; }
    }
}