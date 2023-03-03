
using System;
using System.Xml;

class car
{

    public string name;
    public string år;
    public string vikt;

    public void bil()
    {
        Console.WriteLine("Vilket märke är din bil?");
        name = Console.ReadLine();

        Console.WriteLine("Vilken årsmodell är din bil?");
        år = Console.ReadLine();

        Console.WriteLine("Hur mycket väger din bil?");
        vikt = Console.ReadLine();
    }

    public void run()
    {
        Console.WriteLine("Bilen är en " + name);
        Console.WriteLine("Bilen är en " + år);
        Console.WriteLine("Bilen väger " + vikt + " kg");
    }
}
        
        







namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();

            car1.bil();
            car1.run(); 
            

        }
    }
}
