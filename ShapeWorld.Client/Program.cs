using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
        //access | regular | return | name | parameters
        private static void Main(string[] args)
        {
            PlayWithShape();
        }

        private static void PlayWithShape()
        {
          Shape someShape = new Rectangle();
          Rectangle someSquare = new Square();
          Rectangle someRectangle = new Rectangle() as Square; //casting 
          Rectangle someRectangle2 = (Square) new Rectangle();

          //someSquare.Length = 10;
          //someSquare.Width = 100;        

          Console.WriteLine(someShape.Volume());
          Console.WriteLine(someSquare.Volume());
        }
    }
}
