namespace AggregateSelectWhere;

class Program
{
    static void Main()
    {

        // Aggregate
        var nomes = new List<string> { "Lucas", "Franzen", "Nori" };
        Console.WriteLine($"Seu nome completo é: {usaAggregate(nomes)}\n");

        //Select
        var numeros = new List<int> { 1, 2, 3, 4 };
        Console.WriteLine($"Lista de números: {String.Join(", ", numeros)}");
        Console.Write("Lista de números elevados ao quadrado: ");
        usaSelect(numeros);

        //Where
        numeros = new List<int> { 1, 3, 5, 6, 8, 19 };
        Console.Write("Números pares encontrados: ");
        usaWhere(numeros).ForEach((num) => Console.Write(num + " "));

    }
    
    /// <summary>
    /// Esta função serve para descobrir quais numeros são pares
    /// </summary>
    /// <param name="numeros">Lista de numeros</param>
    /// <returns>Lista de números pares</returns>
    private static List<int> usaWhere(List<int> numeros)
    {
        var numerosPares = numeros.Where((n) => n % 2 == 0).ToList();

        return numerosPares;
    }

    /// <summary>
    /// Esta função pega cada número e o eleva ao quadrado e no final apresenta uma lista desses números
    /// </summary>
    /// <param name="numeros">Lista de números que serão multiplicados</param>
    private static void usaSelect(List<int> numeros)
    {
        var numerosQuadrados = numeros.Select((n) => n * n);

        Console.WriteLine($"{String.Join(", ", numerosQuadrados)}\n");
    }

    /// <summary>
    /// Esta função serve transformar uma lista de nomes em apenas um nome.
    /// </summary>
    /// <param name="nome">Lista de nomes</param>
    /// <returns>Retorna todos os nomes da lista em uma string</returns>
    private static String usaAggregate(List<string> nomes)
    {
        var nomeCompleto = nomes.Aggregate((acc, p) => acc + " " + p);

        return nomeCompleto;

    }
}
