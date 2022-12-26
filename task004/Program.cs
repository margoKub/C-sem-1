Console.WriteLine("Введите целое трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int last_digit = number % 10;
Console.WriteLine($"The last digit of the number is {last_digit}");


