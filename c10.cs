class shape
{
    public virtual void erase()
    {
        Console.WriteLine("erasing a shape")
    }
    public virtual void draw();
    {
        Console.WriteLine("drawing a shape");
    }

}
class circle: shape{
     public virtual void erase()
    {
        Console.WriteLine("erasing a circle")
    }
    public virtual void draw();
    {
        Console.WriteLine("drawing a circle");
    }

}
class square: shape{
    public virtual void erase()
    {
        Console.WriteLine("erasing a square")
    }
    public virtual void draw();
    {
        Console.WriteLine("drawing a square");
    }
}
public class c10
{
    static void Main()
    {
        shape circle=new circle();
        shape square=new square();
        drawandErase(circle);
        drawandErase(square);
    }
    static void drawandErase(shape sh)
    {
        sh.draw();
        sh.erase();
    }
}