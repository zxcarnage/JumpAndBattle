using UnityEngine;

namespace Game.Services.Factory.Chest
{
    public interface ISimpleFactory
    {
        GameObject Spawn(GameObject prefab, Vector3 position);
        GameObject Spawn(GameObject prefab, RectTransform parent);
    }
}