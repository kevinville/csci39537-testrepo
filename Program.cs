using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

interface KrustyKrab
{
    void cookPatty();
    void visitChumBucket();
    void TakeOrders();
}

class Spongebob: KrustyKrab
{
    public void cookPatty()
    {
        Console.WriteLine("Patty is now on Grill!");
    }
    public void visitChumBucket()
    {
        Console.WriteLine("Arrived at front entrance of the chum bucket.");
    }
    public void TakeOrders()
    {
        Console.WriteLine("1 Krabby deluxe and kelp shake.");
    }
}

public partial class Program
{
    static void Main(string[] args)
    {
        Spongebob squidward= new Spongebob();
        Spongebob squarepants = new Spongebob();
        Spongebob plankton = new Spongebob();

        squidward.TakeOrders();
        squarepants.cookPatty();
        plankton.visitChumBucket();

    }
}