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
            
        }

        private static void High(DiContainer container)
        {
            
        }

        private static void Normal(DiContainer container)
        {
            
        }

        private static void Low(DiContainer container)
        {
            
        }
    }
}