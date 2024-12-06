using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class VertexManager
    {
        public List<Vertex> vertexesList = new List<Vertex> { };
        public List<int> free_nums = new List<int> { };
        private int index = 0;

        public void AddVertex(Point point, Graphics graphEgitorBox, int VertexRadius)
        {
            if (free_nums.Count() == 0)
            {
                vertexesList.Add(new Vertex(point, VertexRadius, index, graphEgitorBox));
                index++;
            }
            else
            {
                vertexesList.Add(new Vertex(point, VertexRadius, free_nums.Last(), graphEgitorBox));
                free_nums.Remove(free_nums.Last());
            }
        }

        public void DeleteVertex(Point point)
        {
            Rectangle rect = new Rectangle(point.X, point.Y, 1, 1);

            foreach (var vert in vertexesList)
            {
                if (rect.IntersectsWith(vert.Properties))
                {
                    free_nums.Add(vert.index);
                    vertexesList.Remove(vert);
                    break;
                }
            }
        }

        public void UnselectAll()
        {
            foreach (var vert in vertexesList)
                if (vert.IsSelected)
                    vert.VertexUnselected();
        }

        public int CountSelectedVertexes()
        {
            return vertexesList.Count(vertex => vertex.IsSelected);
        }

        public bool CheckIfClickedOnVert(Point point)
        {
            Rectangle rect = new Rectangle(point.X, point.Y, 1, 1);

            foreach (var vert in vertexesList)
            {
                if (rect.IntersectsWith(vert.Properties) && !vert.IsSelected)
                {
                    vert.VertexSelected();
                    return true;
                }
            }

            return false;
        }

        public void MoveVertex(Point point)
        {
            foreach (var vert in vertexesList)
                if (vert.IsSelected)
                    vert.Move(point);
        }
    }
}
