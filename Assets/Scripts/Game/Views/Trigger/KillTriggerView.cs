using R3;
using R3.Triggers;
using UnityEngine;
using Utils.Layer;
using LayerMask = Utils.Layer.LayerMask;

namespace Game.Views.Trigger
{
    public class KillTriggerView : MonoBehaviour
    {
        [SerializeField]
        private Collider _killCollider;

        private void OnEnable()
        {
            _killCollider.OnTriggerEnterAsObservable()
                .Subscribe(KillEnemy)
                .AddTo(this);
        }

        private void KillEnemy(Collider other)
        {
            if (!other.IsOnLayer(LayerMask.Enemy))
                return;
            
            
        }
    }
}