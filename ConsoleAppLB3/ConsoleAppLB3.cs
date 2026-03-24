// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleAppLB3;

//Transportation t = new Transportation();

//t.FirmName = "ООО Мэгалюлю";
//t.TotalCargoWeight = 100;
//t.CostPerTon = 1;
//t.TrukLoadCopacity = [1, 2, 3];

Transportation t = new Transportation("ООО Мэгалюлю", [50, 100, 50], 100, 20,20);
Transportation t2 = new Transportation("ООО Пожилая ветка сакуры", [50, 100, 50], 150, 25, 400);
Transportation t3 = new Transportation("ООО Пожилая ветка сакуры", [50, 100, 50], 170, 25, 300);
//Transportation t = new Transportation();
//Transportation t = new Transportation("Магэ", 10000);




foreach (var item in t.TrukLoadCopacity)
{
    Console.Write(item);
}


Console.WriteLine();

Console.WriteLine(t.ToString());
//t.m2();
Console.WriteLine();
Console.WriteLine(t.ToString());
Console.WriteLine();
Console.WriteLine(Transportation.ToRents(t,t2,t3));

//t.ToRent(t2);
//Console.WriteLine(t.Rent(t));
//Console.WriteLine(t.GetRevenuePercentage());
//Console.WriteLine(t.ToRent(t2));
//Console.WriteLine($"FirmName:{t.FirmName} TotalCargoWeight: {t.TotalCargoWeight} CostPerTon: {t.CostPerTon} TrukLoadCopacity:::{t.TrukLoadCopacity}");

