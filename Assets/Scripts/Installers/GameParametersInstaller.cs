using Db.Base;
using Db.Base.Impl;
using Db.Enemy;
using Db.Enemy.Impl;
using Db.EnemyBase;
using Db.EnemyBase.Impl;
using Db.Player;
using Db.Player.Impl;
using Db.Ui.BossFight;
using Db.Ui.BossFight.Impl;
using Db.Ui.Treasure;
using Db.Ui.Treasure.Impl;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(menuName = "Installers/" + nameof(GameParametersInstaller), fileName = nameof(GameParametersInstaller))]
    public class GameParametersInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private PrefabsBase _prefabsBase;
        [SerializeField] private EnemyBase _enemyBase;
        [SerializeField] private PlayerBasicParameters _playerBasicParameters;
        [SerializeField] private EnemyParameters _enemyParameters;
        [SerializeField] private BossEnemyParameters _bossEnemyParameters;
        [SerializeField] private BossFightUiParameters _bossFightUiParameters;
        [SerializeField] private TreasureUiParameters _treasureUiParameters;

        public override void InstallBindings()
        {
            Container.Bind<IPrefabsBase>().FromInstance(_prefabsBase).AsSingle();
            Container.Bind<IPlayerBasicParameters>().FromInstance(_playerBasicParameters).AsSingle();
            Container.Bind<IEnemyBase>().FromInstance(_enemyBase).AsSingle();
            Container.Bind<IEnemyParameters>().FromInstance(_enemyParameters).AsSingle();
            Container.Bind<IBossEnemyParameters>().FromInstance(_bossEnemyParameters).AsSingle();
            Container.Bind<IBossFightUiParameters>().FromInstance(_bossFightUiParameters).AsSingle();
            Container.Bind<ITreasureUiParameters>().FromInstance(_treasureUiParameters).AsSingle();
        }
    }
}