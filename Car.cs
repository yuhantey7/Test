using System;
using System.Linq;

class Car
{
    public string X { get; set; }
    public int Y { get; set; }
}

class Program
{
    static void Main()
    {
        string[] strSet1 = new string[] { "A", "B", "C" };
        int[] strSet2 = new int[] { 1, 2, 3, 4 };

        var nResult = from X in strSet1
                      from Y in strSet2
                      where Y % 2 == 0
                      select new Car { X = X, Y = Y };

        foreach (var result in nResult)
        {
            Console.WriteLine($"X: {result.X}, Y: {result.Y}");
        }
    }
}
