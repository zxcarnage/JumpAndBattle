using System;
using System.Collections.Generic;
using Ecs.Generated.Components;
using Scellecs.Morpeh;
using UnityEngine;
using Utils.DebugUtil;
using Zenject;

namespace Ecs.Core.Utils
{
    public class Bootstrap : IInitializable, IDisposable, ITickable, IFixedTickable, ILateTickable
    {
        private readonly IEnumerable<ICleanupSystem> _cleanUpSystems;
        private readonly IEnumerable<IFixedSystem> _fixedUpdateSystems;
        private readonly IEnumerable<ISystem> _updateSystems;
        private readonly IEnumerable<IInitializer> _initializeSystems;
        private readonly World _world;
        
        public Bootstrap(
            World world,
            IEnumerable<ISystem> updateSystems,
            IEnumerable<IFixedSystem> fixedUpdateSystems,
            IEnumerable<ICleanupSystem> cleanUpSystems,
            IEnumerable<IInitializer> initializeSystems
        )
        {
            if (world == null)
                DebugUtility.Log("World is null", UtilsColors.NotificationLightColor);
            _world = world;
            _updateSystems = updateSystems;
            _fixedUpdateSystems = fixedUpdateSystems;
            _cleanUpSystems = cleanUpSystems;
            _initializeSystems = initializeSystems;
        }
 
        public void Initialize()
        {
            var defaultGroup = _world.CreateSystemsGroup();
            ComponentsExtensions.Build(_world);

            foreach (var initializeSystem in _initializeSystems)
            {
                initializeSystem.World = _world;
                defaultGroup.AddInitializer(initializeSystem);
            }
            
            foreach (var updateSystem in _updateSystems)
            {
                updateSystem.World = _world;
                defaultGroup.AddSystem(updateSystem);
            }
 
            foreach (var fixedUpdateSystem in _fixedUpdateSystems)
            {
                fixedUpdateSystem.World = _world;
                defaultGroup.AddSystem(fixedUpdateSystem);
            }
 
            foreach (var cleanUpSystem in _cleanUpSystems)
            {
                cleanUpSystem.World = _world;
                defaultGroup.AddSystem(cleanUpSystem);
            }
            
            _world.AddSystemsGroup(0, defaultGroup);
        }
        
        public void Tick()
        {
            _world.Update(Time.deltaTime);
        }

        public void FixedTick()
        {
            _world.FixedUpdate(Time.fixedDeltaTime);
        }

        public void LateTick()
        {
            _world.CleanupUpdate(Time.deltaTime);
        }

        public void Dispose()
        {
            _world?.Dispose();
        }
    }
}