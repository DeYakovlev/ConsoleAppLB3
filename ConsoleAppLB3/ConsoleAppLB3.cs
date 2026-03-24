// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleAppLB3;

//Transportation t = new Transportation();

//t.FirmName = "ООО Мэгалюлю";
//t.TotalCargoWeight = 100;
//t.CostPerTon = 1;
//t.TrukLoadCopacity = [1, 2, 3];


//Создание нескольких объектов класса
//Конструктор1
Transportation t = new Transportation("ООО Мэгалюлю", [50, 100, 50], 100, 20,20);
Transportation t2 = new Transportation("ООО Пожилая ветка сакуры", [50, 100, 50], 150, 25, 400);
Transportation t3 = new Transportation("ООО Пожилая ветка сакуры", [50, 100, 50], 170, 25, 300);

//Конструктор 2
//Transportation t = new Transportation();

//Конструктор 3
//Transportation t = new Transportation("Магэ", 10000);





foreach (var item in t.TrukLoadCopacity)
{
    Console.Write(item);
}


Console.WriteLine();

//Переопределенный метод ToString
Console.WriteLine(t.ToString());

// Метод метод, определяющий, падение рентабельности (если масса реально перевезенных грузов меньше максимальной более чем на 40%, стоимость падает на 15%)
//t.DownProfit();

Console.WriteLine();
//Переопределенный метод ToString
Console.WriteLine(t.ToString());
Console.WriteLine();
// статический метод, определяющий более рентабельную фирму из трех (возвращает объект, чья рентабельность выше)
Console.WriteLine(Transportation.ToProfits(t, t2,t3));

//метод, определяющий более рентабельную фирму из двух – по проценту рентабельности(возвращает true, если текущая более рентабельна)
//t.ToRent(t2);

//метод для расчета выручки
//Console.WriteLine(t.Profit(t));

//метод для определения процентной выручки от максимально возможной (суммарную грузоподъемность умножить на стоимость перевозки 1 тонны)
//Console.WriteLine(t.GetRevenuePercentage());

//метод для расчета выручки
//Console.WriteLine(t.ToProfit(t2));


//Console.WriteLine($"FirmName:{t.FirmName} TotalCargoWeight: {t.TotalCargoWeight} CostPerTon: {t.CostPerTon} TrukLoadCopacity:::{t.TrukLoadCopacity}");

