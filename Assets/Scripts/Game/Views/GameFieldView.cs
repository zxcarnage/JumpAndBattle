using Cinemachine;
using UnityEngine;
using Utils.SpawnNode;

namespace Game.Views
{
    public class GameFieldView : MonoBehaviour
    {
        [field: SerializeField]
        public Transform PlayerSpawnPoint { get; private set; }

        [field: SerializeField]
        public CinemachineVirtualCamera PlayerCamera { get; private set; }

        [field: SerializeField]
        public SpawnNodeData[] EnemiesSpawnPoints { get; private set; }
    }
}