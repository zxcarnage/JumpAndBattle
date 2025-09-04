using DG.Tweening;

namespace Db.Ui.BossFight
{
    public interface IBossFightUiParameters
    {
        float Duration { get; }
        Ease AnimationEase { get; }
    }
}