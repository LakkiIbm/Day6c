using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class stationary
{
    public abstract void show();
    protected int rate;
    public void cost()
    {
        Console.WriteLine("The cost is:" + rate);
    }
} 
public class Pen : stationary
{
    public override void show()
    {
        rate = 50;
        Console.WriteLine("Pen");
    }
}
public class Pencil : stationary
{
    public override void show()
    {
        rate = 20;
        Console.WriteLine("Pencil");
    }
}
internal class Abstract
{
    static void Main(string[] args)
    {
        stationary s;
        Console.WriteLine("For pen:");
        s = new Pen();
        s.show();
        s.cost();
        Console.WriteLine("For pencil:");
        s = new Pencil();
        s.show();
        s.cost();
        Console.ReadLine();
    }
}

