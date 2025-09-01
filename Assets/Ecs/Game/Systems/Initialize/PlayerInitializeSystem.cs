using Db.Base;
using Db.Player;
using Ecs.Generated.Components;
using Game.Services.Factory.Player;
using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;
using Utils.Providers.GameField;

namespace Ecs.Game.Systems.Initialize
{
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public sealed class PlayerInitializeSystem : IInitializer
    {
        private readonly IPlayerBasicParameters _playerBasicParameters;
        private readonly IPlayerFactory _playerFactory;
        private readonly IGameFieldProvider _gameFieldProvider;
        private readonly IPrefabsBase _prefabsBase;

        public World World { get; set; }

        public PlayerInitializeSystem(
            IGameFieldProvider gameFieldProvider,
            IPlayerBasicParameters playerBasicParameters,
            IPlayerFactory playerFactory,
            IPrefabsBase prefabsBase
        )
        {
            _gameFieldProvider = gameFieldProvider;
            _playerBasicParameters = playerBasicParameters;
            _playerFactory = playerFactory;
            _prefabsBase = prefabsBase;
        }

        public void OnAwake()
        {
            var playerView = _prefabsBase.Get("Player");

            var playerEntity = _playerFactory.CreatePlayer(
                playerView,
                _gameFieldProvider.GameField.PlayerSpawnPoint.position,
                _playerBasicParameters.Health
            );

            InitCamera();

            return;

            void InitCamera()
            {
                var playerTransform = playerEntity.GetTransformComponent().Value;
                _gameFieldProvider.GameField.PlayerCamera.Follow = playerTransform;
                _gameFieldProvider.GameField.PlayerCamera.LookAt = playerTransform;
            }
        }
        
        public void Dispose()
        {
            
        }
    }
}