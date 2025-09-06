using System.Collections.Generic;
using Game.Views.Enemy;
using Utils.Enemy;

namespace Db.EnemyBase
{
    public interface IEnemyBase
    {
        IReadOnlyDictionary<EEnemyType, IReadOnlyList<EnemyView>> EnemiesVariations { get; }
    }
}