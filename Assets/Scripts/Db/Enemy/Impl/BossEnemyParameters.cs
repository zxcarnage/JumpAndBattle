using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Utils.Enemy;

namespace Db.Enemy.Impl
{
    [CreateAssetMenu(menuName = "Settings/" + nameof(BossEnemyParameters), fileName = nameof(BossEnemyParameters))]
    public class BossEnemyParameters : SerializedScriptableObject, IBossEnemyParameters
    {
        [field: SerializeField]
        private Dictionary<EEnemyType, BossEnemyData> _bossDatas;

        public IReadOnlyDictionary<EEnemyType, BossEnemyData> BossDatas => _bossDatas;
    }
}