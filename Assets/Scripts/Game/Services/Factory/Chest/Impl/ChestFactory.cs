using UnityEngine;
using Zenject;

namespace Game.Services.Factory.Chest.Impl
{
    public class ChestFactory : IChestFactory
    {
        private readonly DiContainer _container;

        public ChestFactory(DiContainer container)
        {
            _container = container;
        }
        
        public GameObject Spawn(GameObject prefab, Vector3 position)
        {
            var chest = _container.InstantiatePrefab(prefab);
            chest.transform.position = position;
            return chest;
        }
    }
}