public class Square : Rectengle
{
    public override int Width 
    { 
        set { base.Width = base.Height = value; } 
    }
    public override int Height
    {
        set { base.Width = base.Height = value; }
    }
}