using UnityEngine;

namespace Game.Services.Factory.Chest
{
    public interface IChestFactory
    {
        GameObject Spawn(GameObject prefab, Vector3 position);
    }
}