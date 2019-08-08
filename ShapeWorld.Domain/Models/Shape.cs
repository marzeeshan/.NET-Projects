namespace ShapeWorld.Domain.Models
{

  //Making Shape abstract shows its not real
    public abstract class Shape
    {
        //backing fields
        //private int numberOfEdges;

        //properties
        public int NumberOfEdges { get;}

        //methods

        //virtual = if no permitere specified it will take perimeter for shape
        //virtual: use the parent or change it  
        public virtual double Perimeter()
        {
          return 0;
        }

        //abstract: don't use parent just change it
        public abstract double Surface();

        public double Volume()
        {
          return 0;
        }

        //controllers/constructor
        public Shape(int edges)
        {
          NumberOfEdges = edges;
        }
    }
}