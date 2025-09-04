using KoboldUi.Element.View;
using UnityEngine;
using UnityEngine.UI;

namespace Ui.TreasureUi.View
{
    public class KeyView : AUiSimpleView
    {
        [field: SerializeField]
        public Image Image { get; private set; }
    }
}