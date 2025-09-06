using Game.Services;
using KoboldUi.Services.WindowsService.Impl;
using Zenject;

namespace Installers
{
    public class WinSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<LocalWindowsService>()
                .AsSingle();
            
            Container.Bind<WinBootstrap>().AsSingle().NonLazy();
        }
    }
}