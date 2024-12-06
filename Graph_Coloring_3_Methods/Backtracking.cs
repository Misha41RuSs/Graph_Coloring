using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class BacktrackingColoring : IColorer
    {
        private readonly ColorPalette _palette;

        public BacktrackingColoring(ColorPalette palette)
        {
            _palette = palette;
        }

        public void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox)
        {
            int numVertices = vertexManager.vertexesList.Count;
            Color[] coloring = new Color[numVertices];

            if (TryColorVertex(0, coloring, vertexManager, ribManager))
            {
                for (int i = 0; i < numVertices; i++)
                {
                    vertexManager.vertexesList[i].ColorVertex(coloring[i]);
                }
            }
        }

        private bool TryColorVertex(int vertexIndex, Color[] coloring, VertexManager vertexManager, RibManager ribManager)
        {
            if (vertexIndex == vertexManager.vertexesList.Count)
            {
                return true; // Все вершинки раскрашены
            }

            foreach (Color color in _palette.Colors)
            {
                coloring[vertexIndex] = color;
                if (IsValidSoFar(vertexIndex, coloring, vertexManager, ribManager) &&
                    TryColorVertex(vertexIndex + 1, coloring, vertexManager, ribManager))
                {
                    return true; // Текущая раскраска правильная, красим дальше
                }
            }
            return false; // Нету доступного цвета, возвращаемся назад
        }

        private bool IsValidSoFar(int vertexIndex, Color[] coloring, VertexManager vertexManager, RibManager ribManager)
        {
            int currentVertexIndex = vertexManager.vertexesList[vertexIndex].index;

            for (int i = 0; i < vertexIndex; i++)
            {
                int neighborVertexIndex = vertexManager.vertexesList[i].index;

                if (ribManager.ribsList.Contains(new Point(currentVertexIndex, neighborVertexIndex)) ||
                    ribManager.ribsList.Contains(new Point(neighborVertexIndex, currentVertexIndex)))
                {
                    if (coloring[vertexIndex] == coloring[i])
                        return false; // Текущая вершина того же цвета , что и предыдущая , неправильно
                }
            }
            return true; // Всё четко
        }
    }
}
