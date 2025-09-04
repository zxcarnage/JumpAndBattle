using Db.Base;
using Db.Ui.Treasure;
using Game.Services.Factory.Chest;
using KoboldUi.Element.Controller;
using Ui.TreasureUi.View;
using UnityEngine.UI;
using UnityEngine;
using Utils.Color;

namespace Ui.TreasureUi.Controller
{
    public class TreasureUiController : AUiController<TreasureUiView>
    {
        private readonly ITreasureUiParameters _treasureUiParameters;
        private readonly IPrefabsBase _prefabsBase;
        private readonly ISimpleFactory _factory;

        public TreasureUiController(
            ITreasureUiParameters treasureUiParameters,
            IPrefabsBase prefabsBase,
            ISimpleFactory factory
        )
        {
            _treasureUiParameters = treasureUiParameters;
            _prefabsBase = prefabsBase;
            _factory = factory;
        }

        protected override void OnOpen() //TODO: GETCOMP IS ONLY PROTOTYPE THING
        {
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
                var keyImage = key.GetComponent<KeyView>().Image;
                if (keyImage == null)
                    continue;

                keyImage.color = dominantMask[i]
                    ? dominantColor
                    : palette[(EColor)Random.Range(1, paletteCount)];
            }

            View.DestinationView.SetColor(dominantEColor);
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
    }
}