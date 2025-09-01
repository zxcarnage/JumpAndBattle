namespace Utils.SpawnNode
{
    [System.Serializable]
    public sealed class SpawnNode
    {
        public SpawnNodeData SpawnNodeData { get; private set; }

        public SpawnNode NextNode;

        public SpawnNode(SpawnNodeData spawnNodeData)
        {
            SpawnNodeData = spawnNodeData;
        }
    }
}