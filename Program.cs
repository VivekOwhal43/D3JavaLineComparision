using System;
using System.Reflection.Metadata;
using LineConverter;
//using LineConverter.LineMethods;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LineData lineData = new LineData();
            //lineData.number=5;
            lineData.getAxisPoints();
            lineData.showAxisPoints();
        }
    }
}