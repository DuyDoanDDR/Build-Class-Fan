using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Fan
{
    public const int Slow = 1;
    public const int Medium = 2;
    public const int Fast = 3;

    private int speed = Slow;
    private bool on = false;
    private double radius = 5;
    private string color = "Blue";

    public int SPEED
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool ON
    {
        get { return on; }
        set { on = value; }
    }
    public double RADIUS
    {
        get { return radius; }
        set { radius  = value; }
    }
    public string COLOR
    {
        get { return color; }
        set { color = value; }
    }
    public Fan()
    {
        speed = Slow;
        on = false;
        radius = 5;
        color = "Blue";

    }
    public string ToString()
        
    {
        if(on)
        {
            return $"Speed: {speed}, Color: {color}, Radius: {radius}, Fan is on ";
        }
       else
        {
            return $"Colop: {color}, Radius: {radius}, Fan is off";
        }
    }
}
class Program
{
    static void Main()
    {
        Fan Fan01 = new Fan();
        Fan01.SPEED = Fan.Fast;
        Fan01.RADIUS = 10;
        Fan01.COLOR = "Yellow";
        Fan01.ON = true;
        
        Fan Fan02 = new Fan();
        Fan02.SPEED = Fan.Medium;
        Fan02.RADIUS = 5;
        Fan02.COLOR = "Blue";
        Fan02.ON = false;

        Console.WriteLine(Fan01.ToString());
        Console.WriteLine(Fan02.ToString());
    }

}