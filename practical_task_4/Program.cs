// выводим в консоль текст
Console.WriteLine("введите число 1");
// Человек вводит число
string input1 = Console.ReadLine();
// Введённое число приобразуется в значение
int number1 = Convert.ToInt32(input1);

// делаем запрос на второе число
Console.WriteLine("введите число 2");
// Человек вводит число
string input2 = Console.ReadLine();
// Введённое число приобразуется в значение
int number2 = Convert.ToInt32(input2);

// выводим в консоль текст
Console.WriteLine("введите число 3");
// Человек вводит число
string input3 = Console.ReadLine();
// Введённое число приобразуется в значение
int number3 = Convert.ToInt32(input3);

int max = 0;

if (number1 > number2)
{
max = number1;
}

else
{ max = number2;
} 

if (number3 > max);
{max = number3;
}

Console.WriteLine("Большем чилом является " + number3);
