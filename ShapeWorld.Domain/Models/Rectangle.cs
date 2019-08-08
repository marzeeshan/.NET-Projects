namespace ShapeWorld.Domain.Models
{

  public class Rectangle : Shape
  {
    public virtual double Length { get; set; }
    public virtual double Width { get; set; }


    public override double Perimeter()
    {
      return 2 * (Length + Width);
    }

     public override double Surface()
    {
      return Length * Width;
    }

    //When you use new child does not comply with parent 
    public new double Volume()
    {
      return 1234;
    }
    
    //constructor (when no private set, only constructor can set value once)
    //base is used for inheritance
    public Rectangle() : base(4)
    {

    }
  }

}