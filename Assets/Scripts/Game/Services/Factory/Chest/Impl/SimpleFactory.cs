using UnityEngine;
using Zenject;

namespace Game.Services.Factory.Chest.Impl
{
    public class SimpleFactory : ISimpleFactory
    {
        private readonly DiContainer _container;

        public SimpleFactory(DiContainer container)
        {
            _container = container;
        }
        
        public GameObject Spawn(GameObject prefab, Vector3 position)
        {
            var chest = _container.InstantiatePrefab(prefab);
            chest.transform.position = position;
            return chest;
        }

        public GameObject Spawn(GameObject prefab, RectTransform parent)
        {
            return _container.InstantiatePrefab(prefab, parent);
        }
    }
}