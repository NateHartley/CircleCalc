// See https://aka.ms/new-console-template for more information
public class Circle
{
    static void CircleArea()
    {
        double pi = Math.PI;
        Console.WriteLine("You have chosen to calculate the area of a circle");
        Console.WriteLine("Enter the radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double a = pi * r * r;
        Console.WriteLine("Area = {0}", a);
    }
    
    static void CircleCircumference()
    {
        double pi = Math.PI;
        Console.WriteLine("You have chosen to calculate the circumference of a circle");
        Console.WriteLine("Enter the radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double c = pi * r * 2;
        Console.WriteLine("Circumference = {0}", c);
    }
    
    static void SemiArea()
    {
        double pi = Math.PI;
        Console.WriteLine("You have chosen to calculate the area of a semi-circle");
        Console.WriteLine("Enter the radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double a = (pi * r * r)/2;
        Console.WriteLine("Area = {0}", a);
    }
    
    static void SemiCircumference()
    {
        double pi = Math.PI;
        Console.WriteLine("You have chosen to calculate the circumference of a semi-circle");
        Console.WriteLine("Enter the radius: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double c = (pi * r * 2)/2 +r;
        Console.WriteLine("Circumference = {0}", c);
    }
    
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Type the following number for each function that you want to carry out:");
        Console.WriteLine("(1) Area of a circle");
        Console.WriteLine("(2) Circumference of a circle");
        Console.WriteLine("(3) Area of a semi-circle");
        Console.WriteLine("(4) Circumference of a semi-circle");
        Console.WriteLine();
        string x = Console.ReadLine();

        switch (x)
        {
            case "1":
                CircleArea();
                break;
            case "2":
                CircleCircumference();
                break;
            case "3":
                SemiArea();
                break;
            case "4":
                SemiCircumference();
                break;
        }
    }
    
}

