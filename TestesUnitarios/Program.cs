var calc = new Calculadora();

Console.WriteLine(calc.Numero(calc.Soma(1, 1)));


public class Calculadora
{
    public int Soma(int num1, int num2) => num1+ num2;

    public String Numero(int num) => num switch
    {
        1 => "Um",
        2 => "Dois",
        3 => "Três",
        _ => "Numero qualquer"
    };

    public Boolean Bool(bool  val) => val;
}
