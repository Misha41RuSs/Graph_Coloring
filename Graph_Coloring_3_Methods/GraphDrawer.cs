using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class GraphDrawer
    {
        public Graphics graphEgitorBox;
        private const int VertexRadius = 20;

        public GraphDrawer(Graphics graphEgitorBox)
        {
            this.graphEgitorBox = graphEgitorBox;
        }

        public void DrawGraph(VertexManager vertexManager, RibManager ribManager)
        {
            foreach (Point point in ribManager.ribsList)
                DrawRib(point, vertexManager);

            foreach (var vertex in vertexManager.vertexesList)
                vertex.Draw();
        }

        private void DrawRib(Point point, VertexManager vertexManager)
        {
            Point firstVertexPosition = vertexManager.vertexesList.Find(vertex => point.X == vertex.index).position;
            Point secondVertexPosition = vertexManager.vertexesList.Find(vertex => point.Y == vertex.index).position;

            graphEgitorBox.DrawLine(new Pen(Color.Black), firstVertexPosition, secondVertexPosition);
        }

        
    }
}
