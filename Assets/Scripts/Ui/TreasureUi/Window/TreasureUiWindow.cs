using KoboldUi.Windows;
using Ui.TreasureUi.Controller;
using Ui.TreasureUi.View;
using UnityEngine;

namespace Ui.TreasureUi.Window
{
    public class TreasureUiWindow : AWindow
    {
        [SerializeField] private TreasureUiView _treasureUiView;
        
        protected override void AddControllers()
        {
            AddController<TreasureUiController, TreasureUiView>(_treasureUiView);
        }
    }
}