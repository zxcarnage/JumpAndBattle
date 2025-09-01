using Game.Services.Factory.Player.Impl;
using Game.Views;
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

            Container.BindInterfacesAndSelfTo<PlayerFactory>()
                .AsSingle();
        }
    }
}