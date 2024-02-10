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

    public void printSides()
    {
        Console.WriteLine("Side A: " + A);
        Console.WriteLine("Side B: " + B);
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
}

class Program
{
    public static void Task1()
    {
        ITriangle triangle = new ITriangle(3, 4, 1);
        Console.WriteLine("Perimeter: " + triangle.Perimeter());
        Console.WriteLine("Area: " + triangle.Area());
        Console.WriteLine("Color: " + triangle.Color);
        Console.WriteLine("Is triangle correct: " + triangle.IsTriangleCorrect());
    }
}
