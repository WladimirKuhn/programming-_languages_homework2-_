//Задача 1:
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int number = 27;

if (number % 3 == 0 && number % 27 == 0) 
{
    Console.WriteLine($"Число {number} кратно 3 и 27");
}
else 
{
  Console.WriteLine($"Число {number} не делится нацело на 3 и 27");  
}

//Задача 2:
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


int coordinateX = 2;
int coordinateY = -2;

if (coordinateX == 0 || coordinateY == 0)
{
    Console.WriteLine("Одна из координат равна нулю, введите значение координат отличные от нуля");
}
else if (coordinateX > 0 && coordinateY > 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в I четверти"); 
}
else if (coordinateX < 0 && coordinateY > 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится во II четверти");
}
else if (coordinateX < 0 && coordinateY < 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в III четверти");
}
else if (coordinateX > 0 && coordinateY < 0)
{
    Console.WriteLine($"Точка с координатами {coordinateX}, {coordinateY} находится в IV четверти");
}

// Задача 3:
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int integer = 11;
int firstDigit = integer / 10;
int secondDigit = integer % 10;

if (integer < 10 || integer > 99)
{
    Console.WriteLine($"Число {integer} меньше 10 или больше 99, введите число в диапазоне от 10 до 99");
}
else if (firstDigit > secondDigit)
{
   Console.WriteLine($"Наибольшая цифра числа {integer} = {firstDigit}");
}
else if (firstDigit < secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа {integer} = {secondDigit}");
}
else if (firstDigit == secondDigit)
{
    Console.WriteLine($"Цифры числа {integer} равны");
}

// Задача 4: 
// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int naturalNumber = 0;

if (naturalNumber != 0 && naturalNumber > 0)
{
    while (naturalNumber > 0)
    {
        int n = naturalNumber % 10;
        naturalNumber /= 10;
        Console.Write($"{n} ");
    }
}
else 
{
    Console.WriteLine($"Число {naturalNumber} меньше или равно нулю");
}
//Не могу понять, как вывести цифры в обратном порядке, не используя массив. Можете подсказать в комменте к дз или может будет разбор этой задачи на следующем семинаре?

