using KoboldUi.Services.WindowsService;
using Ui.WinUi;

namespace Game.Services
{
    public class WinBootstrap
    {
        public WinBootstrap(
            ILocalWindowsService localWindowsService    
        )
        {
            localWindowsService.OpenWindow<WinWindow>();
        }
    }
}