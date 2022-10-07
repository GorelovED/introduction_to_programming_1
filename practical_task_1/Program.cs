// Определение входного числа
Console.Write("Введите число ");
int numbers = int.Parse(Console.ReadLine());

// Получение квадрата входного числа
int result = numbers * numbers;

// Вывод чила в консоль
Console.WriteLine($"Квадрат числа {numbers} = {result}");

// Получение квадрата числа математической функцией
int result_2 = Convert.ToInt32(Math.Pow(numbers, 2));
Console.WriteLine($"Квадрат числа {numbers} = {result_2}");

