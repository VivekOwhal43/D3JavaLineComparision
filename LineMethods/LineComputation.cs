using System;
namespace LineConverter.LineMethods;

public class LineComputation : LineData
{
    new public void getAxisPoints()
    {
        Console.WriteLine("============ Entere Points =================");
        Console.WriteLine("Enter value for X1: ");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for X2: ");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for Y1: ");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter value for Y1: ");
        y2 = Convert.ToInt32(Console.ReadLine());
    }

    new public void showAxisPoints()
    {
        Console.WriteLine("============Entered Values Are =================");
        Console.WriteLine("X1 = " + x1);
        Console.WriteLine("Y1 = " + y1);
        Console.WriteLine("X2 = " + x2);
        Console.WriteLine("Y2 = " + y2);
        double powerx = Math.Pow((x2 - x1), 2);
        double powery = Math.Pow((x2 - x1), 2);
        //length_of_line 
        length_of_line = Math.Sqrt(powerx + powery);
        length_of_line = Math.Round(length_of_line);
        if (length_of_line < 0)
        {
            Console.WriteLine("Enter correct values");
        }
        //length_of_line = Math.abs(length_of_line);
        else
        {
            Console.WriteLine("Length of Line: " + length_of_line + " Cm");
        }
    }
}