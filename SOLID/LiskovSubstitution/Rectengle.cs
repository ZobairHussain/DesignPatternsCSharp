public class Rectengle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public Rectengle()
    {

    }

    public Rectengle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string? ToString()
    {
        return $"width = {Width}, height = {Height}";
    }
}
