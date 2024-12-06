using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class GraphColoring
    {
        public List<Color> colorsList = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Magenta, Color.Cyan, Color.Yellow };
        private int num = 0;

        public void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox)
        {
            int MatrixSize = vertexManager.vertexesList.Count();

            List<int> color_indexes = Enumerable.Repeat(0, MatrixSize).ToList();

            int matrixIlength = ifSlowModeCheckBox ? ++num : MatrixSize;

            for (int i = 0; i < matrixIlength; i++)
            {
                int VertexIndexI = vertexManager.vertexesList[i].index;

                for (int j = 0; j < MatrixSize; j++)
                {
                    int VertexIndexJ = vertexManager.vertexesList[j].index;

                    if (ribManager.ribsList.Contains(new Point(VertexIndexI, VertexIndexJ)) && color_indexes[i] == color_indexes[j])
                        color_indexes[j]++;
                }

                vertexManager.vertexesList[i].ColorVertex(colorsList[color_indexes[i]]);
            }
        }
    }
}
