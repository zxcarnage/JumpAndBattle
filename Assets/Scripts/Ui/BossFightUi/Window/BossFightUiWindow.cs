using KoboldUi.Windows;
using Ui.BossFightUi.Controller;
using Ui.BossFightUi.View;
using UnityEngine;

namespace Ui.BossFightUi.Window
{
    public class BossFightUiWindow : AWindow
    {
        [SerializeField] private BossFightUiView _bossFightView;
        
        protected override void AddControllers()
        {
            AddController<BossFightUiController, BossFightUiView>(_bossFightView);  
        }
    }
}