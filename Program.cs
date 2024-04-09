using flyweight_design_pattern.Entities;
using flyweight_design_pattern.Enums;
using flyweight_design_pattern.Factories;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine("Flyweight Design Pattern");
Console.WriteLine("------------------------");
Console.ForegroundColor = ConsoleColor.Magenta;

var peterParker = (SpiderMan)SuperHeroFactory.GetSuperHero(SuperHeroEnum.ESuperHero.SpiderMan);
peterParker.SetName("Peter Parker");
peterParker.Create();

var milesMorales = (SpiderMan)SuperHeroFactory.GetSuperHero(SuperHeroEnum.ESuperHero.SpiderMan);
milesMorales.SetName("Miles Morales");
milesMorales.Create();

var gwenStacy = (SpiderMan)SuperHeroFactory.GetSuperHero(SuperHeroEnum.ESuperHero.SpiderMan);
gwenStacy.SetName("Gwen Stacy");
gwenStacy.Create();

SuperHeroFactory.ListCachedSuperHeroes();
