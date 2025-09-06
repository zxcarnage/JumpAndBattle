using System;
using KoboldUi.Element.Controller;
using R3;
using UnityEngine.SceneManagement;

namespace Ui.WinUi
{
    public class WinController : AUiController<WinView>
    {
        private IDisposable _disposable;
        
        public override void Initialize()
        {
            _disposable = View.RestartButton
                .OnClickAsObservable()
                .Subscribe(_ => RestartGame());
        }
        
        private void RestartGame()
        {
            SceneManager.LoadScene(0);
        }

        protected override void OnClose()
        {
            _disposable?.Dispose();
        }
    }
}