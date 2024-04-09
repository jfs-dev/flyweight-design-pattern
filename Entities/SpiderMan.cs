using flyweight_design_pattern.Interfaces;

namespace flyweight_design_pattern.Entities;

public class SpiderMan() : ISuperHero
{
    public string Name { get; private set; } = string.Empty;

     private readonly List<string> specialPowers =
     [
        "Agilidade Aracnídea",
        "Sentido Aranha",
        "Força Aumentada"
    ];

    public void SetName(string name) => Name = name;

    public void Create() => Console.WriteLine($"Nome: { Name } - Super Poderes: { string.Join(", ", specialPowers ) }");
}
