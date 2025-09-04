using DG.Tweening;
using UnityEngine;

namespace Db.Ui.BossFight
{
    [CreateAssetMenu(menuName = "Settings/" + nameof(BossFightUiParameters), fileName = nameof(BossFightUiParameters))]
    public class BossFightUiParameters : ScriptableObject, IBossFightUiParameters
    {
        [field: SerializeField]
        public float Duration { get; private set; }
        
        [field: SerializeField]
        public Ease AnimationEase { get; private set; }
    }
}