using Course_Intermediate_AbstractClass.Entities.Enums;

namespace Course_Intermediate_AbstractClass.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
