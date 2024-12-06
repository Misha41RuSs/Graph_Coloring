using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class Graph
    {
        private VertexManager vertexManager;
        private RibManager ribManager;
        private GraphDrawer graphDrawer;
        private GreedyColoring graphColoring;

        public Graph(Graphics graphEgitorBox)
        {
            vertexManager = new VertexManager();
            ribManager = new RibManager();
            graphDrawer = new GraphDrawer(graphEgitorBox);
            ColorPalette palette = new ColorPalette();
            graphColoring = new GreedyColoring(palette);
        }

        public void AddVertex(Point point)
        {
            vertexManager.AddVertex(point, graphDrawer.graphEgitorBox, 20);
            graphDrawer.DrawGraph(vertexManager, ribManager);
        }

        public void DeleteVertex(Point point)
        {
            vertexManager.DeleteVertex(point);
            graphDrawer.DrawGraph(vertexManager, ribManager);
        }

        public void AddRib()
        {
            ribManager.AddRib(vertexManager);
            graphDrawer.DrawGraph(vertexManager, ribManager);
        }

        public void DeleteRib()
        {
            ribManager.DeleteRib(vertexManager);
            graphDrawer.DrawGraph(vertexManager, ribManager);
        }

        public void Coloring(bool ifSlowModeCheckBox)
        {
            graphColoring.Coloring(vertexManager, ribManager, ifSlowModeCheckBox);
        }

        public void DrawGraph()
        {
            graphDrawer.DrawGraph(vertexManager, ribManager);
        }

        public void UnselectAll()
        {
            vertexManager.UnselectAll();
        }

        public int CountSelectedVertexes()
        {
            return vertexManager.CountSelectedVertexes();
        }

        public bool CheckIfClickedOnVert(Point point)
        {
            return vertexManager.CheckIfClickedOnVert(point);
        }

        public void MoveVertex(Point point)
        {
            vertexManager.MoveVertex(point);
        }
    }
}

