using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using LineConverter;
//using LineConverter.LineMethods;
namespace ConsoleApplication
{
    class Program
    {
        LineData lineData = new LineData();
        LineData lineData2 = new LineData();
        LineData lineData3 = new LineData();
        public void uc1()
        {
            Console.WriteLine("Use Case 1");
            
            lineData.getAxisPoints();
            lineData.showAxisPoints();
        }

        public void uc2()
        {
            Console.WriteLine("Enter information for 2 lines: ");
            
            Console.WriteLine("Data For First Line:");
            lineData2.getAxisPoints();
            Console.WriteLine("Data For Second Line:");
            lineData3.getAxisPoints();

            lineData2.showAxisPoints();
            lineData3.showAxisPoints();

            double line1 = lineData2.length_of_line;
            double line2 = lineData3.length_of_line;
            if (line1.Equals(line2))
            {
                Console.WriteLine("Line is Equal");
            }
            else
            {
                Console.WriteLine("Line is Not Equal");
            }
        }
        public void uc3()
        {
            Console.WriteLine("Data For First Line:");
            lineData2.getAxisPoints();
            Console.WriteLine("Data For Second Line:");
            lineData3.getAxisPoints();
            double line1 = lineData2.length_of_line;
            double line2 = lineData3.length_of_line;
            var result = line1.CompareTo(line2);
            if(result>0)
            Console.WriteLine("First line is greater than Second line");

            else if (result < 0)
                Console.WriteLine("First line is less than Second line");

            else
                Console.WriteLine("Both Line are Equal");
            
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("Enter Your Choice: \n1. Obtain Lenght of Line \n2.Chceck if two lines are equal \n3.Comparison of lines (Equal, Less or Greater)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                
                case 1:
                p1.uc1();
                    break;

                case 2:
                p1.uc2();
                
                    break;

                case 3:
                p1.uc3();
                    break;
            }
        }
    }
}
