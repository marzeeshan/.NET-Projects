namespace ShapeWorld.Domain.Models
{
  
  // (Square : Shape) Square is the child getting from parent Shape 
  public class Square : Rectangle
  { 
    private double _edgeLength;
    public override double Length { 
      get
      {
        return _edgeLength;
      } 
      set
      {
        _edgeLength = value;
      }
    }

    public override double Width { 
      get
      {
        return _edgeLength;
      } 
      set
      {
        _edgeLength = value;
      }
    }
  }
}