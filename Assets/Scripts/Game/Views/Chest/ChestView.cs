using KoboldUi.Services.WindowsService;
using R3;
using R3.Triggers;
using Ui.TreasureUi.Window;
using UnityEngine;
using Utils.Layer;
using Zenject;
using LayerMask = Utils.Layer.LayerMask;

namespace Game.Views.Chest
{
    public class ChestView : MonoBehaviour
    {
        [SerializeField] private Collider _collider;
        
        private ILocalWindowsService _localWindowsService;

        [Inject]
        private void Construct(
            ILocalWindowsService localWindowsService
        )
        {
            _localWindowsService = localWindowsService;
        }

        private void OnEnable()
        {
            _collider.OnTriggerEnterAsObservable()
                .Subscribe(ChestTriggerEnter)
                .AddTo(this);
        }

        private void ChestTriggerEnter(Collider other)
        {
            if (!other.IsOnLayer(LayerMask.Player))
                return;
            
            _localWindowsService.OpenWindow<TreasureUiWindow>();
        }
    }
}