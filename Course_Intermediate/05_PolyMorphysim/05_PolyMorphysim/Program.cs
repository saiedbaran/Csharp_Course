using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_PolyMorphysim.Overrider;

namespace _05_PolyMorphysim
{
    class Program
    {
        static void Main(string[] args)
        {
            OVR_DrawShape();
        }

        private static void OVR_DrawShape()
        {
            var shapes = new List<Shape>
            {
                new Circle() {Height = 10, Position = new Position() {XPos = 0, YPos = 0}, Width = 10},
                new Rectangle() {Height = 5, Position = new Position() {XPos = 5, YPos = 5}, Width = 5}
            };

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
