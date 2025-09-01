using Sirenix.OdinInspector;

namespace Utils.PrefabMatrix
{
    public class PrefabMatrixAttribute : TableMatrixAttribute
    {
        public PrefabMatrixAttribute()
        {
            SquareCells = true;
            HideColumnIndices = true;
            HideRowIndices = true;
            ResizableColumns = false;
        }
    }
}