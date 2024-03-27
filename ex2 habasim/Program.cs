using System;

class Program
{
    static void Main(string[] args)
    {
        int typOfTower = 0;
        while (typOfTower != 3)
        {
            Console.WriteLine("enter 1 to tower rectangle \n enter 2 to tower triangular \n enter 3 to exit");
            typOfTower = int.Parse(Console.ReadLine());
            switch (typOfTower)
            {
                case 1:
                    TowerRectangle();
                    break;
                case 2:
                    TowerTriangular();
                    break;
                case 3:
                    Console.WriteLine("exit");
                    break;
                default:
                    Console.WriteLine("The input not valid pleas enter value");
                    break;
            }
        }
    }

    static void TowerRectangle()
    {
        Console.WriteLine("Enter the height and width of the tower");
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        if (height == width || Math.Abs(height - width) > 5)
        {
            double area = height * width;
            Console.WriteLine("The area is " + area);
        }
        else
        {
            double perimeter = 2 * (height + width);
            Console.WriteLine("The perimeter is " + perimeter);
        }
    }

    static void TowerTriangular()
    {
        Console.WriteLine("Enter the height and width of the tower");
        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 1 to calculate the perimeter of the triangle \nenter 2 to calculate the area of the triangle");
        int theOption = int.Parse(Console.ReadLine());
        switch (theOption)
        {
            case 1:
                double widthPitagoras = width / 2;
                double rib = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(widthPitagoras, 2));
                double perimeter = rib * 2 + width;
                Console.WriteLine("The perimeter is " + perimeter);
                break;
            case 2:
                if (width % 2 != 0 && height * 2 > width)
                {
                    int tempWidth = width;
                    width = width - 2;
                    height = height - 2;
                    int numRows = width / 2;
                    int division = height / numRows;
                    int divisionRemainder = height % numRows;
                    Console.WriteLine(new string(' ', (tempWidth - 1) / 2) + "*");
                    int i = 3;
                    for (int j = 0; j < numRows; j++)
                    {
                        string numSpaces = new string(' ', (tempWidth - i) / 2);
                        string numStar = new string('*', i);
                        Console.Write(string.Concat(Enumerable.Repeat(numSpaces + numStar + "\n", j == 0 ? division + divisionRemainder : division)));
                        i += 2;
                    }
                    Console.WriteLine(new string('*', tempWidth));
                }
                else
                {
                    Console.WriteLine("Unable to print the triangle");
                }
                break;
            default:
                Console.WriteLine("The input not valid pleas enter value");
                break;
        }
    }
}