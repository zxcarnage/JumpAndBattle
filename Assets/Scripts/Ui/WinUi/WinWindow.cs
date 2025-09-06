using KoboldUi.Windows;
using UnityEngine;

namespace Ui.WinUi
{
    public class WinWindow : AWindow
    {
        [SerializeField] private WinView _winView;
        
        protected override void AddControllers()
        {
            AddController<WinController, WinView>(_winView);
        }
    }
}