using System.Reflection;

namespace Using_myDLL_with_System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //Define DLL path
        Assembly myDLL = Assembly.LoadFile(@"C:\Users\franzen\Desktop\Area de trabalho\Estudos\C# .NET\Anotações\myFirstDLL\bin\Debug\net8.0\myFirstDLL.dll");

        //Creating a type passing the namespace which I want
        Type mathClass = myDLL.GetType("myFirstDLL.FranzenMath");

        //Create a instance of my type
        dynamic instanceFranzenMath = Activator.CreateInstance(mathClass);

        //Define my method passing the method name
        var sum = mathClass.GetMethod("Sum");

        //Invoking the method passing the instance first and then the parameters
        double result = sum.Invoke(instanceFranzenMath, new object?[] { 10, 5 });


        /* PRINTING RESULT */
        Console.WriteLine($"Sum result: {result}");
        Console.ReadKey();

    }
}
