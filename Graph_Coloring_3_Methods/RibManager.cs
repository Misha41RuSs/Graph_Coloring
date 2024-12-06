using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class RibManager
    {
        public List<Point> ribsList = new List<Point> { };

        public void AddRib(VertexManager vertexManager)
        {
            List<Vertex> v = new List<Vertex> { };
            foreach (var vert in vertexManager.vertexesList)
            {
                if (vert.IsSelected)
                {
                    v.Add(vert);
                    vert.VertexUnselected();
                }
            }

            ribsList.Add(new Point(v[0].index, v[1].index));
        }

        public void DeleteRib(VertexManager vertexManager)
        {
            List<Vertex> v = vertexManager.vertexesList.FindAll(vertex => vertex.IsSelected);

            foreach (var Point in ribsList)
            {
                if (Point.X == v[0].index && Point.Y == v[1].index || Point.Y == v[0].index && Point.X == v[1].index)
                {
                    ribsList.Remove(Point);
                    break;
                }
            }
        }

        public void ForRemovingEveryRibOnVertex(Vertex vert)
        {
            foreach (var Point in ribsList)
            {
                if (Point.X == vert.index || Point.Y == vert.index)
                {
                    ribsList.Remove(Point);
                    ForRemovingEveryRibOnVertex(vert);
                    break;
                }
            }
        }
    }
}
