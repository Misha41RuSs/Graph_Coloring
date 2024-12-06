using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class ColorPalette
    {
        public List<Color> Colors { get; set; }
        public ColorPalette()
        {
            Colors = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Magenta, Color.Cyan, Color.Yellow };
        }
    }
}
