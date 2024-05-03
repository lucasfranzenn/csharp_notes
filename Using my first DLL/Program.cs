using myFirstDLL;
using static System.Console;

namespace Using_my_first_DLL;

class Program
{
    static void Main(string[] args)
    {
        double x = 10;
        double y = 5;

        WriteLine($"Sum of {x} and {y} = {FranzenMath.Sum(10, 5)}");
        WriteLine($"Multiply of {x} and {y} = {FranzenMath.Multiply(10, 5)}");

        ReadKey(true);
    }
}
