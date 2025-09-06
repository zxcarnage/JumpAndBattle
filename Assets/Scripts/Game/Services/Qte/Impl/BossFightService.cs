using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using KoboldUi.Services.WindowsService;
using Scellecs.Morpeh;
using Ui.BossFightUi.Window;
using UnityEngine;

namespace Game.Services.Qte.Impl
{
    public class BossFightService : IBossFightService
    {
        private readonly ILocalWindowsService _localWindowsService;

        private readonly Filter _playerFilter;

        public BossFightService(
            World world,
            ILocalWindowsService localWindowsService
        )
        {
            _localWindowsService = localWindowsService;

            _playerFilter = world.Filter
                .With<PlayerComponent>()
                .Build();
        }
        
        public void StartFight()
        {
            var playerEntity = _playerFilter.First();

            playerEntity.GetRigidbodyComponent().Value.velocity = Vector3.zero;
            playerEntity.AddInBossFightComponent(new InBossFightComponent());
            playerEntity.AddEnableTapShootingComponent(new EnableTapShootingComponent());
            _localWindowsService.OpenWindow<BossFightUiWindow>();
        }
    }
}