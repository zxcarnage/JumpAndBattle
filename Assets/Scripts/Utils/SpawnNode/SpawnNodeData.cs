using UnityEngine;

namespace Utils.SpawnNode
{
    [System.Serializable]
    public struct SpawnNodeData
    {
        public Transform SpawnPosition;
        public float Delay;
        public float MovementSpeed;
    }
}