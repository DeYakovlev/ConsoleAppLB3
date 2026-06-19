// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using ConsoleAppLB3;
using System.Text;

//Transportation t = new Transportation();

//t.FirmName = "ООО Мэгалюлю";
//t.TotalCargoWeight = 100;
//t.CostPerTon = 1;
//t.TrukLoadCopacity = [1, 2, 3];


//Создание нескольких объектов класса
//Конструктор1
Transportation t = new Transportation("ООО Мэгалюлю", [50, 100, 50], 100, 20,20);
Transportation t2 = new Transportation("ООО Пожилая ветка сакуры", [25, 50, 100], 150, 25, 400);
Transportation t3 = new Transportation("ООО Пожилая ветка сакуры", [50, 100, 50], 170, 25, 300);

//Конструктор 2
Transportation t4 = new Transportation();

//Конструктор 3
Transportation t5 = new Transportation("Магэ", 10000);


//Демонстрация всех видом конструкторов
Console.WriteLine("Демонстрация всех видом конструкторов\n");
Console.WriteLine($"Конструктор полным набором полей(аргументов):\n {t.ToString()}\n");
Console.WriteLine($"Конструктор частичным набором полей(аргументов):\n {t5.ToString()}\n");
Console.WriteLine($"Конструктор без полей(аргументов):\n {t4.ToString()}\n");


//Демонстрация свойств класса 
Console.WriteLine("Демонстрация свойств класса\n");
Console.WriteLine("Свойство FirmName");
Console.WriteLine($"Get FirmName : {t.FirmName}");
t.FirmName = "ООО Новая организация";
Console.WriteLine($"Get FirmName после Set FirmName : {t.FirmName}");
Console.WriteLine();

Console.WriteLine("Свойство TotalCargoWeight");
Console.WriteLine($"Get TotalCargoWeight : {t.TotalCargoWeight}");
t.TotalCargoWeight = 30;
Console.WriteLine($"Get TotalCargoWeight после Set TotalCargoWeight : {t.TotalCargoWeight}");
Console.WriteLine();

Console.WriteLine("Свойство TrukLoadCopacity");
var sb = new StringBuilder();
bool first = true;
foreach (var item in t.TrukLoadCopacity)
{
    if (!first)
        sb.Append(" ");
    sb.Append(item);
    first = false;
 
}
string SRT = sb.ToString();
Console.WriteLine($"Get TrukLoadCopacity : {SRT}");
t.TrukLoadCopacity = [100, 50, 100];
sb.Clear();
first = true;
foreach (var item in t.TrukLoadCopacity)
{
    if (!first)
        sb.Append(" ");
    sb.Append(item);
    first = false;

}
SRT = sb.ToString();
Console.WriteLine($"Get TrukLoadCopacity после Set TrukLoadCopacity : {SRT}");
Console.WriteLine();


//Переопределенный метод ToString
Console.WriteLine("Переопределенный метод ToString");
Console.WriteLine(t.ToString());
Console.WriteLine();

//метод для определения процентной выручки от максимально возможной (суммарную грузоподъемность умножить на стоимость перевозки 1 тонны)
Console.WriteLine("Метод для определения процентной выручки от максимально возможной");
Console.WriteLine($"Потенциальная выручка: {t.GetRevenuePercentage()}");
Console.WriteLine();

// Метод метод, определяющий, падение рентабельности (если масса реально перевезенных грузов меньше максимальной более чем на 40%, стоимость падает на 15%)
Console.WriteLine("Метод метод, определяющий, падение рентабельности");
Console.WriteLine($"Цена до выполнения метода: {t2.CostPerTon}");
t2.DownProfit();
Console.WriteLine($"Цена после выполнения метода: {t2.CostPerTon}");
Console.WriteLine();


// статический метод, определяющий более рентабельную фирму из трех (возвращает объект, чья рентабельность выше)
Console.WriteLine("Статический метод, определяющий более рентабельную фирму из трех");
Console.WriteLine($"Самая рентабельная фирма:\n {Transportation.ToProfits(t, t2, t3)}");
Console.WriteLine();


//метод, определяющий более рентабельную фирму из двух – по проценту рентабельности(возвращает true, если текущая более рентабельна)
Console.WriteLine("Сравнивает текущую фирму с выбранной");
string YesNo = "Да";
if(!t2.ToProfit(t))
    YesNo = "Нет";
Console.WriteLine($"Текущая фирма рентабельней? - {YesNo}");



//Cвойство для подсчета выурчки
//Console.WriteLine();
//Console.WriteLine(t.Profitability);

//метод для расчета выручки
//Console.WriteLine(t.Profit(t));

//метод для расчета выручки
//Console.WriteLine(t.ToProfit(t2));

//Console.WriteLine($"FirmName:{t.FirmName} TotalCargoWeight: {t.TotalCargoWeight} CostPerTon: {t.CostPerTon} TrukLoadCopacity:::{t.TrukLoadCopacity}");