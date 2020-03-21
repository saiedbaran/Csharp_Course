using System.Collections.Generic;

namespace _05_PolyMorphysim.Overrider
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}