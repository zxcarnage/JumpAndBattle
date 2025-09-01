using UnityEngine;

namespace Db.Base
{
    public interface IPrefabsBase
    {
        GameObject Get(string prefabName);
    }
}