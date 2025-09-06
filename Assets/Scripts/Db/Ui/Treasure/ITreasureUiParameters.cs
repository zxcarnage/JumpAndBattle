using System.Collections.Generic;
using UnityEngine;
using Utils.Color;

namespace Db.Ui.Treasure
{
    public interface ITreasureUiParameters
    {
        int KeysCount { get; }
        IReadOnlyDictionary<EColor,Color> KeyColors { get; }
    }
}