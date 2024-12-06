using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class GreedyColoring : IColorer
    {
        private ColorPalette _palette;

        public GreedyColoring(ColorPalette palette)
        {
            _palette = palette;
        }

        public void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox)
        {
            int MatrixSize = vertexManager.vertexesList.Count();

            List<int> color_indexes = Enumerable.Repeat(0, MatrixSize).ToList();

            int matrixIlength = ifSlowModeCheckBox ? 1 : MatrixSize;

            for (int i = 0; i < matrixIlength; i++)
            {
                int VertexIndexI = vertexManager.vertexesList[i].index;

                for (int j = 0; j < MatrixSize; j++)
                {
                    int VertexIndexJ = vertexManager.vertexesList[j].index;

                    if (ribManager.ribsList.Contains(new Point(VertexIndexI, VertexIndexJ)) && color_indexes[i] == color_indexes[j])
                        color_indexes[j]++;
                }

                vertexManager.vertexesList[i].ColorVertex(_palette.Colors[color_indexes[i]]);
            }
        }
    }
}
