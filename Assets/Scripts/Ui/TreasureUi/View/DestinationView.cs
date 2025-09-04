using Db.Ui.Treasure;
using KoboldUi.Element.View;
using UnityEngine;
using UnityEngine.UI;
using Utils.Color;
using Zenject;

namespace Ui.TreasureUi.View
{
    public class DestinationView : AUiSimpleView
    {
        private ITreasureUiParameters _treasureUiParameters;

        [SerializeField]
        private Image _image;

        private EColor _color;

        [Inject]
        public void Construct(
            ITreasureUiParameters treasureUiParameters    
        )
        {
            _treasureUiParameters = treasureUiParameters;
        }

        public void SetColor(EColor color)
        {
            _image.color = _treasureUiParameters.KeyColors[color];
            _color = color;
        }
    }
}