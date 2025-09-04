using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Scellecs.Morpeh;
using UnityEngine.SceneManagement;

namespace Ecs.Game.Systems.Death
{
    public sealed class PlayerDeathSystem : ISystem
    {
        private Filter _deadPlayerFilter;
        
        public World World { get; set; }

        public void OnAwake()
        {
            _deadPlayerFilter = World.Filter
                .With<PlayerComponent>()
                .With<DeathComponent>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            var isPlayerDead = _deadPlayerFilter.IsNotEmpty();

            if (!isPlayerDead) 
                return;

            SceneManager.LoadScene(0);
        }

        public void Dispose()
        {
        }
    }
}