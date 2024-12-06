using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal interface IColorer
    {
        void Coloring(VertexManager vertexManager, RibManager ribManager, bool ifSlowModeCheckBox);
    }
}
