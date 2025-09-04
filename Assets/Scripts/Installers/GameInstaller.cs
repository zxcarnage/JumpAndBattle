using Game.Services.Factory.Chest.Impl;
using Game.Services.Factory.Enemy.Impl;
using Game.Services.Factory.Player.Impl;
using Game.Services.Pool.Enemy.Impls;
using Game.Services.Qte.Impl;
using Game.Views;
using KoboldUi.Services.WindowsService.Impl;
using UnityEngine;
using Utils.Providers.GameField.Impl;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameFieldView _gameFieldView;
        
        public override void InstallBindings()
        {
            var gameFieldProvider = new GameFieldProvider(_gameFieldView);
            
            Container.BindInterfacesAndSelfTo<PlayerInputAction>()
                .FromNew()
                .AsSingle();

            Container.BindInterfacesAndSelfTo<GameFieldProvider>()
                .FromInstance(gameFieldProvider)
                .AsSingle();

            BindFactories();
            BindServices();
        }

        private void BindServices()
        {
            Container.BindInterfacesAndSelfTo<EnemyPool>()
                .AsSingle();
            Container.BindInterfacesAndSelfTo<BossFightService>()
                .AsSingle();
            Container.BindInterfacesAndSelfTo<LocalWindowsService>()
                .AsSingle();
        }

        private void BindFactories()
        {
            Container.BindInterfacesAndSelfTo<PlayerFactory>()
                .AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyFactory>()
                .AsSingle();
            Container.BindInterfacesAndSelfTo<SimpleFactory>()
                .AsSingle();
        }
    }
}