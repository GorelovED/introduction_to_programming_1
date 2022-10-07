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
// Если чило 1 больше числа 2 выводится текст и значение 1 числа
if (number1 > number2)
{
Console.WriteLine("Число " + number1 + " больше");
}
// Если число 2 больше числа 1 выводится текст и значение 2 числа
if (number1 < number2)
{
Console.WriteLine("Число " + number2 + " больше");
}
// Если человек ввёл одинаковое чило выдаёт ошибку
if (number1 == number2) 
{
Console.WriteLine("Вы ввели одинаковые числа");
}