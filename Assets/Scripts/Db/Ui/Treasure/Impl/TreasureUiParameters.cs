using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Utils.Color;

namespace Db.Ui.Treasure.Impl
{
    [CreateAssetMenu(menuName = "Settings/" + nameof(TreasureUiParameters), fileName = nameof(TreasureUiParameters))]
    public class TreasureUiParameters : SerializedScriptableObject, ITreasureUiParameters
    {
        [field: SerializeField]
        public int KeysCount { get; private set; }

        [SerializeField]
        private Dictionary<EColor, Color> _keyColors;

        public IReadOnlyDictionary<EColor, Color> KeyColors => _keyColors;
    }
}