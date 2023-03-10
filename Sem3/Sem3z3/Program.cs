//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X);          // Вызов метода с передачей параметров по значению
                                     // -------------------------- Конец программы ----------------------------------
                                     // -------------------------Определение методов ---------------------------------
                                     // ------------------------------------------------------------------------------
                                     // Определяем функцию, выполняющую ввод значений координат
//Console.WriteLine(Y);
static void InitCoordinatesByUser(ref int x, ref int y) 
{
    while (y==0){
    try
    {
        Console.Write("Введите номер четверти: ");
        x = int.Parse(Console.ReadLine() ?? "");
        if (x<1 || x>4){
            Console.WriteLine("Ошибка! Такая четверть не существует!");
            y=0;}
        else y = 1;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
       // y=0;
        //return;
    }
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и выводящую в консоль номер четверти плоскости, в которой находится эта точка
static void PrintQuarterByCoords(int x)
{
    if (x == 1)
        Console.WriteLine("x > 0 и y > 0");
    else if (x == 2)
        Console.WriteLine("x < 0 и y > 0");
    else if (x == 3)
        Console.WriteLine("x < 0 и y < 0");
    else
        Console.WriteLine("x > 0 и y < 0");

        
    
        
}
// ---------------------- Конец определения методов ----------------------------
