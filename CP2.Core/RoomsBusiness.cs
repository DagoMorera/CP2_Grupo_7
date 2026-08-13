using CP2.Architecture;
using CP2.Architecture.Providers;
using CP2.Data;
using CP2.Data.Global;
using CP2.Data.Models;
using Microsoft.EntityFrameworkCore;
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
    IReadOnlyDictionary<int, string> roomConfigs,
    FoodbankContext foodbankContext)
    : RoomsBase(restProvider, secureHashService, roomConfigs), IRoomsBusiness
{
    private readonly IRestProvider _restProvider = restProvider;
    private readonly FoodbankContext _foodbankContext = foodbankContext;

    public async Task<bool> SolutionIndexAsync(string code)
    {
        await Task.CompletedTask;
        return Evaluate(0, code);
    }

    // Room 1: el jugador calcula "{x}{x^2}{3x}{x^3}" por su cuenta (probando x entre 2 y 10)
    // y envía el RESULTADO ya calculado en "num". El backend solo compara ese resultado.
    public async Task<bool> SolutionRoom1Async(int num)
    {
        await Task.CompletedTask;
        return Evaluate(1, num.ToString());
    }

    public async Task<bool> SolutionRoom2Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(2, code);
    }

    public async Task<bool> SolutionRoom3Async(string code)
    {
        var hash = new SecureHashService(
            "E4A1F9B7C32D8F64A9F1C0D3B7E2A6CC4F18B92ED0C4A7F1D3B89C6A5F2E1D44");

        return hash.Validate(
            code,
            "s0+cAcAI8p+zqhoIZtVjRr+HSLnTHp6NVa5YmTw1Ie4=");
    }

    // Room 4: el input "code" ya llega como JSON armado por el JS de la vista.
    public async Task<bool> SolutionRoom4Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(4, code);
    }

    // Room 5: traducción a LINQ de:
    // SELECT [Ingredients] FROM FoodItems
    // WHERE Ingredients LIKE '%game%' AND Price BETWEEN 6.5 AND 7 AND IsPerishable = 1
    // El resultado se arma como "x, y, z" (mismo formato pedido en la vista).
    public async Task<bool> SolutionRoom5Async()
    {
        var ingredients = await _foodbankContext.FoodItems
            .Where(f => f.Ingredients.Contains("game")
                     && f.Price >= 6.5m && f.Price <= 7m
                     && f.IsPerishable == true)
            .Select(f => f.Ingredients)
            .ToListAsync();

        var result = string.Join(", ", ingredients);

        return Evaluate(5, result);
    }

    // Room 6: se corre la cadena de responsabilidad de CP2.COR (initialValue = 1)
    // por su cuenta y envía el resultado numérico final. El backend solo compara.
    public async Task<bool> SolutionRoom6Async(int num)
    {
        await Task.CompletedTask;
        return Evaluate(6, num.ToString());
    }

    public async Task<bool> SolutionRoom7Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(7, code);
    }

    // Room 8: array fijo dado en el enunciado. Se encuentra el número que aparece
    // una sola vez (los demás aparecen exactamente 3 veces) en O(n) tiempo y O(1) memoria
    // extra, usando conteo de bits módulo 3.
    public async Task<bool> SolutionRoom8Async()
    {
        await Task.CompletedTask;

        int[] arr = { 3, 3, 6, 22, 9, 7, 1, 6, 4, 9, 3, 6, 4, 1, 1, 2, 4, 22, 22, 7, 7, 9 };

        var ones = 0;
        var twos = 0;

        foreach (var n in arr)
        {
            ones = (ones ^ n) & ~twos;
            twos = (twos ^ n) & ~ones;
        }
        return Evaluate(8, ones.ToString());
    }

    public async Task<bool> SolutionRoom9Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(9, code);
    }

    public async Task<bool> SolutionRoom10Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(10, code);
    }

    public async Task<bool> SolutionRoom11Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(11, code);
    }

    public async Task<bool> SolutionRoom12Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(12, code);
    }

    public async Task<bool> SolutionRoom13Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(13, code);
    }

    public async Task<bool> SolutionRoom14Async(string code)
    {
        await Task.CompletedTask;
        return Evaluate(14, code);
    }

    public async Task<bool> CanExitTheRoomsAsync(string code)
    {
        await Task.CompletedTask;
        return Evaluate(15, code);
    }
}