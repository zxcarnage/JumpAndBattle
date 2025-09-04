using KoboldUi.Utils;
using Ui.BossFightUi.Window;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(menuName = "Installers/" + nameof(GameUiInstaller), fileName = nameof(GameUiInstaller))]
    public class GameUiInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas _canvas;
        
        [Header("Windows")]
        [SerializeField]
        private BossFightUiWindow _bossFightUiWindow;

        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(_canvas);
            
            Container.BindWindowFromPrefab(canvasInstance, _bossFightUiWindow);
        }
    }
}