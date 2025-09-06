using System.Collections.Generic;
using Utils.Enemy;

namespace Db.Enemy
{
    public interface IBossEnemyParameters
    {
        IReadOnlyDictionary<EEnemyType, BossEnemyData> BossDatas { get; }
    }
}