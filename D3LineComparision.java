import java.util.Scanner;
//import java.math.*;
class D3LineComparision{
    Scanner scanner = new Scanner(System.in);
    int x1, y1, x2, y2;
    double length_of_line;
    
    public void getAxisPoints()     //Method fo Accepting values from user.
    {
        System.out.println("Enter value for X1: ");
        x1 = scanner.nextInt();
        System.out.println("Enter value for Y1: ");
        y1 = scanner.nextInt();
        System.out.println("Enter value for X2: ");
        x2 = scanner.nextInt();
        System.out.println("Enter value for Y2: ");
        y2 = scanner.nextInt();
    }

    public void showAxisPoints()        // method for showing entered values
    {
        System.out.println("============Entered Values Are =================");
        System.out.println("X1 = "+x1);
        System.out.println("Y1 = "+y1);
        System.out.println("X2 = "+x2);
        System.out.println("Y2 = "+y2);
        length_of_line = Math.sqrt((x2-x1)+(y2-y1));
        if(length_of_line<0){
            System.out.println("Enter correct values");
        }
        //length_of_line = Math.abs(length_of_line);
        else{
        System.out.println("Length of Line: "+length_of_line+" Cm");
        }
    }

    public static void main(String args[])
    {
        //create object of class and access methods to
        //get input from user and show on console
        D3LineComparision d3LineComparision = new D3LineComparision();
        d3LineComparision.getAxisPoints();
        d3LineComparision.showAxisPoints();
    }
}