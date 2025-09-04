using UnityEngine;

namespace Db.Enemy.Impl
{
    [CreateAssetMenu(menuName = "Settings/" + nameof(EnemyParameters), fileName = nameof(EnemyParameters))]
    public class EnemyParameters : ScriptableObject, IEnemyParameters
    {
        [field: SerializeField]
        public float MaxPassedDistance { get; private set; }
    }
}