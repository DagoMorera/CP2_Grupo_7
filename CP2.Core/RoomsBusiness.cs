using CP2.Architecture;
using CP2.Architecture.Providers;
using CP2.Data.Global;
using System.Text.Json;

namespace CP2.Core;

public interface IRoomsBusiness
{
    Task<bool> SolutionIndexAsync(string code);
    Task<bool> SolutionRoom1Async(int num);
    Task<bool> SolutionRoom2Async(string code);
    Task<bool> SolutionRoom3Async(string code);
    Task<bool> SolutionRoom4Async(string code);
    Task<bool> SolutionRoom5Async();
    Task<bool> SolutionRoom6Async(int num);
    Task<bool> SolutionRoom7Async(string code);
    Task<bool> SolutionRoom8Async();
    Task<bool> SolutionRoom9Async(string code);
    Task<bool> SolutionRoom10Async(string code);
    Task<bool> SolutionRoom11Async(string code);
    Task<bool> SolutionRoom12Async(string code);
    Task<bool> SolutionRoom13Async(string code);
    Task<bool> SolutionRoom14Async(string code);
    Task<bool> CanExitTheRoomsAsync(string code);
}

public class RoomsBusiness(
    IRestProvider restProvider,
    SecureHashService secureHashService,
    IReadOnlyDictionary<int, string> roomConfigs) : RoomsBase(restProvider, secureHashService, roomConfigs), IRoomsBusiness
{
    private readonly IRestProvider _restProvider = restProvider;

    public async Task<bool> SolutionTestAsync(string code)
    {
        // solucion aqui
        code = "test";

        // codiguito aqui
        // lalalala lalalala
        // code = resultado de lalalal

        var resultHash = Evaluate(0, code);
        var resultApi = await CallApiAsync("test", code);
        return (resultHash && resultApi);
    }

    public async Task<bool> SolutionIndexAsync(string code)
    {
        // solucion aqui
        var resultHash = Evaluate(0, code);
        var resultApi = await CallApiAsync("test", code);
        return (resultHash && resultApi);
    }

    public async Task<bool> SolutionRoom1Async(int x)
    {
        // resuelven 
        var resultHash = Evaluate(1, x.ToString());
        var resultApi = await CallApiAsync("test", x.ToString());
        return (resultHash && resultApi);
    }

    public async Task<bool> SolutionRoom2Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom3Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom4Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom5Async()
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom6Async(int num)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom7Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom8Async()
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom9Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> SolutionRoom10Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom11Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom12Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom13Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
    public async Task<bool> SolutionRoom14Async(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }

    public async Task<bool> CanExitTheRoomsAsync(string code)
    {
        // solucion aqui
        return true; // Placeholder logic
    }
}