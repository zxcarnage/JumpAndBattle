using System.Collections.Generic;
using Db.Base;
using Db.Ui.Treasure;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using Game.Services.Factory.Chest;
using KoboldUi.Element.Controller;
using R3;
using Scellecs.Morpeh;
using Ui.TreasureUi.View;
using UnityEngine;
using Utils.Color;

namespace Ui.TreasureUi.Controller
{
    public class TreasureUiController : AUiController<TreasureUiView>
    {
        private readonly ITreasureUiParameters _treasureUiParameters;
        private readonly IPrefabsBase _prefabsBase;
        private readonly ISimpleFactory _factory;
        private readonly World _world;
        private readonly List<KeyView> _keyViews = new List<KeyView>();
        private readonly CompositeDisposable _disposable = new CompositeDisposable();

        private Filter _playerFilter;

        public TreasureUiController(
            ITreasureUiParameters treasureUiParameters,
            World world,
            IPrefabsBase prefabsBase,
            ISimpleFactory factory
        )
        {
            _treasureUiParameters = treasureUiParameters;
            _world = world;
            _prefabsBase = prefabsBase;
            _factory = factory;
        }

        public override void Initialize()
        {
            _playerFilter = _world.Filter
                .With<PlayerComponent>()
                .Build();
        }

        protected override void OnOpen() //TODO: ONLY PROTOTYPE THING
        {
            ChangeGameState(true);
            _keyViews.Clear();
            
            var keyPrefab = _prefabsBase.Get("Key");
            var totalKeys = _treasureUiParameters.KeysCount;
            var palette = _treasureUiParameters.KeyColors;

            var paletteCount = palette.Count;
            var dominantEColor = (EColor)Random.Range(1, paletteCount);
            var dominantColor = palette[dominantEColor];
            var guaranteedCount = Mathf.Min(3, totalKeys);

            var dominantMask = GenerateDominantMask(totalKeys, guaranteedCount);

            for (var i = 0; i < totalKeys; i++)
            {
                var key = _factory.Spawn(keyPrefab, View.KeyParent);
                var keyView = key.GetComponent<KeyView>();
                _keyViews.Add(keyView);

                if (dominantMask[i])
                {
                    keyView.SetColor(dominantEColor, dominantColor);
                }
                else
                {
                    var eColor = (EColor)Random.Range(1, paletteCount);
                    var targetColor = palette[eColor];
                    keyView.SetColor(eColor, targetColor);
                }

                keyView.OnDragEnded
                    .Subscribe(OnDragEndedOnDestination)
                    .AddTo(_disposable);
            }

            View.DestinationView.SetColor(dominantEColor);
        }

        private void OnDragEndedOnDestination(KeyView keyView)
        {
            var targetColor = View.DestinationView.Color;

            if (keyView.TryMatchColor(targetColor))
            {
                View.DestinationView.RightKeyDropped();
                return;
            }
            
            keyView.ReturnToOriginalPosition();
        }

        protected override void OnClose()
        {
            _disposable?.Clear();
            ChangeGameState(false);
        }

        private static bool[] GenerateDominantMask(int total, int guaranteed)
        {
            var mask = new bool[total];
            if (total <= 0 || guaranteed <= 0)
                return mask;

            var indices = new int[total];
            for (var i = 0; i < total; i++)
                indices[i] = i;

            for (var i = total - 1; i > 0; i--)
            {
                var j = Random.Range(0, i + 1);
                (indices[i], indices[j]) = (indices[j], indices[i]);
            }

            var take = Mathf.Min(guaranteed, total);
            for (var k = 0; k < take; k++)
                mask[indices[k]] = true;

            return mask;
        }

        private void ChangeGameState(bool isPaused)
        {
            foreach (var playerEntity in _playerFilter)
            {
                if(isPaused)
                    playerEntity.SetMovementBlockedComponent(new MovementBlockedComponent());
                else
                    playerEntity.RemoveMovementBlockedComponent();
            }

            Time.timeScale = isPaused ? 0 : 1;
        }
    }
}