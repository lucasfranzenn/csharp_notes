namespace Async_and_await;

class Program
{
    public static async Task<string> BuyCake(string name)
    {
        Console.WriteLine($"{name} going to market at {DateTime.Now.ToString()}");
        await Task.Delay(2000);
        Console.WriteLine($"{name} buying the cake at {DateTime.Now.ToString()}");
        await Task.Delay(2000);
        Console.WriteLine($"{name} going to home at {DateTime.Now.ToString()}");

        return "CheeseCake";
    }
    public static async Task<string> BuyGame(string name)
    {
        Console.WriteLine($"{name} going to market at {DateTime.Now.ToString()}");
        await Task.Delay(2000);
        Console.WriteLine($"{name} buying the game at {DateTime.Now.ToString()}");
        await Task.Delay(2000);
        Console.WriteLine($"{name} going to home at {DateTime.Now.ToString()}");

        return "Minecraft";
    }

    public static async void MarketShopping()
    {
        Task<string> cakeTask = BuyCake("Lucas");
        Task<string> gameTask = BuyGame("Matthew");

        string cakeFlavor = await cakeTask;
        string gameBought = await gameTask;

        Console.WriteLine($"\nI like {gameBought} and {cakeFlavor}\n");

    }



    static void Main(string[] args)
    {
        MarketShopping();

        Console.ReadKey(true);
    }
}
