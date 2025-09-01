using Ecs.Core.Utils;
using Scellecs.Morpeh;
using Zenject;

namespace Ecs.Core.Installers
{
    public class GameEcsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var world = World.Default;

            Container.Bind<World>()
                .FromInstance(world)
                .AsSingle();

            GameEcsSystems.Install(Container);
            
            Container.BindInterfacesAndSelfTo<Bootstrap>().AsSingle().NonLazy();
        }
    }
}