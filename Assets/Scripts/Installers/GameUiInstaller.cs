using KoboldUi.Utils;
using Ui.BossFightUi.Window;
using Ui.TreasureUi.Window;
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
        
        [SerializeField]
        private TreasureUiWindow _treasureWindow;

        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(_canvas);
            
            Container.BindWindowFromPrefab(canvasInstance, _bossFightUiWindow);
            Container.BindWindowFromPrefab(canvasInstance, _treasureWindow);
        }
    }
}