using Db.Ui.Treasure;
using KoboldUi.Element.View;
using KoboldUi.UiAction;
using KoboldUi.UiAction.Pool;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Utils;
using Utils.Color;
using Zenject;

namespace Ui.TreasureUi.View
{
    public class DestinationView : AUiSimpleView
    {
        private ITreasureUiParameters _treasureUiParameters;

        [SerializeField]
        private Image _image;
        
        [SerializeField]
        private TMP_Text _keysCounter;

        public EColor Color { get; private set; }

        private int _keysCount;

        [Inject]
        public void Construct(
            ITreasureUiParameters treasureUiParameters    
        )
        {
            _treasureUiParameters = treasureUiParameters;
        }

        public override void Initialize()
        {
            _keysCount = 0;
        }

        protected override IUiAction OnOpen(in IUiActionsPool pool)
        {
            UpdateText();
            return base.OnOpen(in pool);
        }

        public void SetColor(EColor color)
        {
            _image.color = _treasureUiParameters.KeyColors[color];
            Color = color;
        }

        public void RightKeyDropped()
        {
            _keysCount++;
            UpdateText();

            if (_keysCount == ConstValues.KEY_WIN_CONDITION)
                SceneManager.LoadScene(1); //TODO: ONLY PROTOTYPE AS WITH PLAYER DEATH

        }

        private void UpdateText()
        {
            _keysCounter.text = $"{_keysCount}/3";
        }
    }
}