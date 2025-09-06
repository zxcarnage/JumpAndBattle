using KoboldUi.Utils;
using Ui.WinUi;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(menuName = "Installers/" + nameof(WinSceneUiInstaller), fileName = nameof(WinSceneUiInstaller))]
    public class WinSceneUiInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas _canvas;
        
        [Header("Windows")]
        [SerializeField]
        private WinWindow _winWindow;
        
        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(_canvas);
            
            Container.BindWindowFromPrefab(canvasInstance, _winWindow);
        }
    }
}