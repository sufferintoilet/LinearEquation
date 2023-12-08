using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    { 
        Console.WriteLine("enter a");
        Double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter b");
        Double b = Convert.ToDouble(Console.ReadLine());

        if(a!=0)
            Console.WriteLine("Pt co nghiem" + -b/a);
        else if(b==0)
            Console.WriteLine("vo so nghiem");
        else 
            Console.WriteLine("vo nghiem");
        
       
    }
}