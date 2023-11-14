// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld


{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 4, 6, 8 };
        int i = 1;
        arr[i++] = arr[i] + 10;
        // arr[2] = arr[1]+10
        // 6+10 = arr[1]
        // 16 = arr[1]
        
        // int[] arr = {2, 16, 6, 8}
        
        arr[i] = arr[i++] * 2;
        // arr[2] = arr[2]*2;
        // arr[2] = 12

    
        Console.WriteLine(string.Join(",", arr));

    }
}
