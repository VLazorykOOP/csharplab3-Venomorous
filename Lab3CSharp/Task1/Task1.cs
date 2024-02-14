using System;

namespace Triangle;

class ITriangle
{
    protected int a;
    protected int b;

    protected int color;

    public ITriangle(int a, int b, int color)
    {
        //if (a < 0 || b < 0)
        //{
        //    throw new ArgumentException("Sides must be greater than 0");
        //}

        if (!IsTriangleCorrect(a, b))
        {
            throw new ArgumentException("Triangle is not correct");
        }

        this.a = a;
        this.b = b;
        this.color = color;
    }

    public int A
    {
        get => a;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Side A must be greater than 0");
            }
            a = value;
        }
    }

    public int B
    {
        get => b;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Side B must be greater than 0");
            }
            b = value;
        }
    }

    public int Color
    {
        get => color;
    }

    public void PrintSides()
    {
        Console.WriteLine("Sides:");
        Console.WriteLine("  Side A: " + A);
        Console.WriteLine("  Side B: " + B);
        Console.WriteLine("  Side C: " + A);
    }

    public int Perimeter()
    {
        return A * 2 + B;
    }

    public double Area()
    {
        double area = (B / 2) * Math.Sqrt(A * A - (B * B) / 4);
        return Math.Round(area, 2);
    }

    public bool IsTriangleCorrect()
    {
        return A + B > A && A + B > B;
    }

    private static bool IsTriangleCorrect(int a, int b)
    {
        return a + b > a && a + b > b;
    }

    public static void PrintTriangle(ITriangle triangle)
    {
        Console.WriteLine("-----------------------------------------------------------");
        triangle.PrintSides();
        Console.WriteLine("Triangle perimeter: " + triangle.Perimeter());
        Console.WriteLine("Triangle area: " + triangle.Area());
        Console.WriteLine("Triangle color: " + triangle.Color);
    }

    public static void PrintAllTriangles(ITriangle[] triangles)
    {
        foreach (var triangle in triangles)
        {
            PrintTriangle(triangle);
        }
    }
}

class Program
{
    public static void Task1()
    {
        ITriangle[] triangles = new ITriangle[]
        {
            new ITriangle(3, 4, 1),
            new ITriangle(5, 7, 2),
            new ITriangle(8, 15, 3),
        };

        ITriangle.PrintAllTriangles(triangles);
    }
}
