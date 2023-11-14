public class MyClass
{
    // Readonly field can only be assigned a value at the time of declaration or in the constructor.
    public readonly int ReadonlyField;

    // Constructor to initialize the readonly field.
    public MyClass(int value)
    {
        ReadonlyField = value;
    }

    // Other methods and properties can be defined here.
}

class Program
{
    static void Main()
    {
        // Create an instance of MyClass
        MyClass myObject = new MyClass(42);

        // Access the readonly field
        Console.WriteLine($"ReadonlyField value: {myObject.ReadonlyField}");

        // Attempting to modify the readonly field will result in a compilation error.
        // myObject.ReadonlyField = 10; // This line would cause a compilation error.
    }
}
