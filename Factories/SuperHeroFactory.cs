using flyweight_design_pattern.Entities;
using flyweight_design_pattern.Enums;
using flyweight_design_pattern.Interfaces;

namespace flyweight_design_pattern.Factories;

public class SuperHeroFactory
{
    private static readonly Dictionary<SuperHeroEnum.ESuperHero, ISuperHero> superHeroes = [];

    public static ISuperHero GetSuperHero(SuperHeroEnum.ESuperHero superHero)
    {
        if (!superHeroes.TryGetValue(superHero, out ISuperHero? value))
        {
            value = superHero switch
            {
                SuperHeroEnum.ESuperHero.SpiderMan => new SpiderMan(),
                _ => throw new ArgumentException("Super-herói desconhecido!"),
            };

            superHeroes[superHero] = value;
        }

        return value;
    }

    public static void ListCachedSuperHeroes()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("Flyweights em cache");
        Console.WriteLine("-------------------");
        Console.ForegroundColor = ConsoleColor.Magenta;
        
        foreach (var kvp in superHeroes)
            Console.WriteLine($"Tipo: { kvp.Key } - Objeto: { kvp.Value }");
    }
}
