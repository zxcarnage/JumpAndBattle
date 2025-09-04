using System;
using Game.Services.Factory.Enemy;
using R3;
using R3.Triggers;
using UnityEngine;
using Utils.Enemy;
using Utils.Layer;
using Zenject;
using LayerMask = Utils.Layer.LayerMask;

namespace Game.Views.BossRoad
{
    public class BossRoadView : MonoBehaviour //TODO: prototype thing, better to be decomposed
    {
        [SerializeField]
        private Transform[] _enemySpawnPoints;

        [SerializeField]
        private Collider _enterTrigger;

        private IEnemyFactory _enemyFactory;

        [Inject]
        private void Construct(
            IEnemyFactory enemyFactory    
        )
        {
            _enemyFactory = enemyFactory;
        }

        private void OnEnable()
        {
            _enterTrigger.OnTriggerEnterAsObservable()
                .Subscribe(OnTriggerEnter)
                .AddTo(this);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.IsOnLayer(LayerMask.Player))
                return;

            foreach (var spawnPoint in _enemySpawnPoints)
            {
                _enemyFactory.CreateBossEnemy(EEnemyType.Boss, spawnPoint.position);
            }
        }
    }
}