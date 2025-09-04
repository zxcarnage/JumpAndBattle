using Ecs.Game.Systems.BossFight;
using Ecs.Game.Systems.Death;
using Ecs.Game.Systems.Enemy;
using Ecs.Game.Systems.Initialize;
using Ecs.Game.Systems.Input;
using Ecs.Game.Systems.Movement;
using Ecs.Game.Systems.Spawn;
using Zenject;

namespace Ecs.Core.Installers
{
    public static class GameEcsSystems
    {
        public static void Install(DiContainer container){
            Urgent(container);
            High(container);
            Normal(container);
            Low(container);
        }

        private static void Urgent(DiContainer container)
        {
            container.BindInterfacesAndSelfTo<InputInitializeSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<PlayerInitializeSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<RoadsInitializeSystem>().AsSingle();
        }

        private static void High(DiContainer container)
        {
            container.BindInterfacesAndSelfTo<KeyboardInputSystem>().AsSingle();
        }

        private static void Normal(DiContainer container)
        {
            container.BindInterfacesAndSelfTo<PlayerMovementSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<EnemySpawnSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<EnemyMovementSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<KillEnemySystem>().AsSingle();
            container.BindInterfacesAndSelfTo<PlayerDeathSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<BossFightSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<EnemyDeathSystem>().AsSingle();
            container.BindInterfacesAndSelfTo<WinBossFightSystem>().AsSingle();
        }

        private static void Low(DiContainer container)
        {
            
        }
    }
}