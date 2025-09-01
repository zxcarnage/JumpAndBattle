using UnityEngine;

namespace Utils.PrefabMatrix
{
    public interface IPrefabMatrix<T>
    {
        GameObject[,] PrefabMatrix { get; set; }
        T[] ToArray();
    }
}