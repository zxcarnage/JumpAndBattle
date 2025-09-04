using Db.Ui.BossFight;
using DG.Tweening;
using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using KoboldUi.Element.Controller;
using Scellecs.Morpeh;
using Ui.BossFightUi.View;

namespace Ui.BossFightUi.Controller
{
    public class BossFightUiController : AUiController<BossFightUiView>
    {
        private readonly IBossFightUiParameters _bossFightUiParameters;
        private readonly World _world;

        private Tween _countTween;
        private Filter _playerFilter;

        public BossFightUiController(
            IBossFightUiParameters bossFightUiParameters,
            World world
        )
        {
            _bossFightUiParameters = bossFightUiParameters;
            _world = world;
        }

        public override void Initialize()
        {
            _playerFilter = _world.Filter
                .With<PlayerComponent>()
                .With<MovementBlockedComponent>()
                .Build();
            
            _countTween = View.CounterSlider
                .DOValue(0f, _bossFightUiParameters.Duration)
                .SetEase(_bossFightUiParameters.AnimationEase)
                .OnComplete(TimeEnded)
                .Pause();
        }

        protected override void OnOpen()
        {
            View.CounterSlider.value = 1f;
            _countTween.Restart();
        }

        private void TimeEnded()
        {
            foreach (var playerEntity in _playerFilter)
            {
                playerEntity.AddDeathComponent(new DeathComponent());
            }
        }

        protected override void OnClose()
        {
            _countTween.Pause();
            View.CounterSlider.value = 1f;
        }
    }
}