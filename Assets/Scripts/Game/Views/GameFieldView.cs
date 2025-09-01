using UnityEngine;

namespace Game.Views
{
    public class GameFieldView : MonoBehaviour
    {
        [field: SerializeField]
        public Transform PlayerSpawnPoint { get; private set; }
    }
}