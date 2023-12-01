namespace CH4;

public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }
    
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    
    public double CalculateArea()
    {
        return Length * Width;
    }
}
