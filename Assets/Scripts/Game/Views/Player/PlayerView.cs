using Ecs.Game.Components.Character;
using Ecs.Game.Components.Player;
using Ecs.Generated.Components;
using R3;
using R3.Triggers;
using Scellecs.Morpeh;
using UnityEngine;
using Utils.Layer;
using Zenject;
using LayerMask = Utils.Layer.LayerMask;

namespace Game.Views.Player
{
    public class PlayerView : ACharacterView
    {
        private Filter _playerFilter;
        private World _world;

        [Inject]
        private void Construct(World world)
        {
            _world = world;
        }
       
        private void OnEnable()
        {
            _playerFilter = _world.Filter
                .With<PlayerComponent>()
                .Build();
            
            Collider.OnCollisionEnterAsObservable().Subscribe(OnCollisionEnter).AddTo(this);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.collider.IsOnLayer(LayerMask.Enemy))
                return;

            var playerEntity = _playerFilter.First();
            playerEntity.SetDeathComponent(new DeathComponent());
        }
    }
}