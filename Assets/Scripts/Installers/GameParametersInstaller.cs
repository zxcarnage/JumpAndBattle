using Db.Base;
using Db.Base.Impl;
using Db.EnemyBase;
using Db.EnemyBase.Impl;
using Db.Player;
using Db.Player.Impl;
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

        public override void InstallBindings()
        {
            Container.Bind<IPrefabsBase>().FromInstance(_prefabsBase).AsSingle();
            Container.Bind<IPlayerBasicParameters>().FromInstance(_playerBasicParameters).AsSingle();
            Container.Bind<IEnemyBase>().FromInstance(_enemyBase).AsSingle();
        }
    }
}