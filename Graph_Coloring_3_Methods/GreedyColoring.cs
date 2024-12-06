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
        private List<int> _colorIndexes;
        private int _currentVertexIndex;

        public GreedyColoring(ColorPalette palette)
        {
            _palette = palette;
            _colorIndexes = new List<int>();
            _currentVertexIndex = 0;
        }

        public void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox)
        {
            int matrixSize = vertexManager.vertexesList.Count();

            if (_colorIndexes.Count == 0)
            {
                _colorIndexes = Enumerable.Repeat(0, matrixSize).ToList();
            }

            if (ifSlowModeCheckBox)
            {
                if (_currentVertexIndex < matrixSize)
                {
                    int vertexIndexI = vertexManager.vertexesList[_currentVertexIndex].index;

                    for (int j = 0; j < matrixSize; j++)
                    {
                        int vertexIndexJ = vertexManager.vertexesList[j].index;

                        if (ribManager.ribsList.Contains(new Point(vertexIndexI, vertexIndexJ)) && _colorIndexes[_currentVertexIndex] == _colorIndexes[j])
                            _colorIndexes[j]++;
                    }

                    vertexManager.vertexesList[_currentVertexIndex].ColorVertex(_palette.Colors[_colorIndexes[_currentVertexIndex]]);
                    _currentVertexIndex++;
                }
                else
                {
                    _currentVertexIndex = 0;
                }
            }
            else
            {
                for (int i = 0; i < matrixSize; i++)
                {
                    int vertexIndexI = vertexManager.vertexesList[i].index;

                    for (int j = 0; j < matrixSize; j++)
                    {
                        int vertexIndexJ = vertexManager.vertexesList[j].index;

                        if (ribManager.ribsList.Contains(new Point(vertexIndexI, vertexIndexJ)) && _colorIndexes[i] == _colorIndexes[j])
                            _colorIndexes[j]++;
                    }

                    vertexManager.vertexesList[i].ColorVertex(_palette.Colors[_colorIndexes[i]]);
                }
            }
        }
    }
}