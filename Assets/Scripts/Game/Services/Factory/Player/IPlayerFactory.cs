using Scellecs.Morpeh;
using UnityEngine;

namespace Game.Services.Factory.Player
{
    public interface IPlayerFactory
    {
        Entity CreatePlayer(GameObject prefab, Vector3 position, int maxHealth);
    }
}