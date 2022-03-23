using System;
using System.Collections;
using System.Reflection.Metadata;
using LineConverter;
//using LineConverter.LineMethods;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice: \n1. Obtain Lenght of Line \n2.Chceck if two lines are equal");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("");
                    LineData lineData = new LineData();
                    lineData.getAxisPoints();
                    lineData.showAxisPoints();
                break;

                case 2:
                //Console.WriteLine("Null Method");
                    Console.WriteLine("Enter information for 2 lines: ");
                    LineData lineData2 = new LineData();
                    lineData2.getAxisPoints();
                    lineData2.showAxisPoints();
                
                    LineData lineData3 = new LineData();
                    lineData3.getAxisPoints();
                    lineData3.showAxisPoints();

                    double line1 = lineData2.length_of_line;
                    double line2 = lineData3.length_of_line;
                    if(line1.Equals(line2))
                    {
                        Console.WriteLine("Line is Equal");
                    }
                    else
                    {
                        Console.WriteLine("Line is Not Equal");
                    }
                break;

                case 3:
                Console.WriteLine("Line is Equal");
                break;
            }
            
            //lineData.number=5;
            //lineData.getAxisPoints();
            //lineData.showAxisPoints();
        }
    }
}