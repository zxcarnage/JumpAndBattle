using System.Collections.Generic;
using KoboldUi.Element.View;
using KoboldUi.UiAction;
using KoboldUi.UiAction.Pool;
using R3;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils.Color;

namespace Ui.TreasureUi.View
{
    public class KeyView : AUiSimpleView, IDragHandler, IEndDragHandler //TODO: PROTOTYPE VIEW, NOT OPTIMIZED FOR REAL PROJECTS
    {
        [SerializeField]
        private Image _image;
        
        [SerializeField]
        private RectTransform _rectTransform;
        
        [SerializeField]
        private CanvasGroup _canvasGroup;

        private Vector2 _originalPosition;
        private bool _isInteractable = true;

        public ReactiveCommand<KeyView> OnDragEnded { get; } = new ReactiveCommand<KeyView>();

        private EColor _color;

        protected override IUiAction OnOpen(in IUiActionsPool pool)
        {
            _originalPosition = _rectTransform.anchoredPosition;
            _canvasGroup.blocksRaycasts = true;
            return base.OnOpen(in pool);
        }

        public void SetColor(EColor eColor, Color target)
        {
            _color = eColor;
            _image.color = target;
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (!_isInteractable) 
                return;
            _rectTransform.anchoredPosition += eventData.delta;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (!_isInteractable) 
                return;

            _canvasGroup.blocksRaycasts = false;
            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, results);
            
            foreach (var result in results)
            {
                var destinationView = result.gameObject.GetComponent<DestinationView>();
                
                if (destinationView == null) 
                    continue;

                OnDragEnded?.Execute(this);
                return;
            }

            ReturnToOriginalPosition();
        }

        public void ReturnToOriginalPosition()
        {
            _rectTransform.anchoredPosition = _originalPosition;
        }

        private void DisableKey()
        {
            _isInteractable = false;
            _image.gameObject.SetActive(false);
        }

        public bool TryMatchColor(EColor targetColor)
        {
            if (_color != targetColor) 
                return false;

            DisableKey();
            
            return true;
        }
    }
}