namespace _05_PolyMorphysim.Overrider
{
    public class Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}