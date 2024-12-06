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
        private int current_i = 0;

        public GreedyColoring(ColorPalette palette)
        {
            _palette = palette;
        }

        public void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox)
        {
            int MatrixSize = vertexManager.vertexesList.Count();

            List<int> color_indexes = Enumerable.Repeat(0, MatrixSize).ToList();

            int matrixIlength = ifSlowModeCheckBox ? current_i + 1 : MatrixSize;
            current_i = ifSlowModeCheckBox ? current_i + 1 : 0;

            if (current_i > MatrixSize) current_i = 0;

            for (int i = 0; i < matrixIlength; i++)
            {
                if (i >= MatrixSize) break;
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
