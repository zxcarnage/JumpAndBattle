namespace Utils.SpawnNode
{
    [System.Serializable]
    public sealed class SpawnNode
    {
        private SpawnNodeData _spawnNodeData;
        
        public SpawnNode NextNode;

        public SpawnNode(SpawnNodeData spawnNodeData)
        {
            _spawnNodeData = spawnNodeData;
        }
    }
}