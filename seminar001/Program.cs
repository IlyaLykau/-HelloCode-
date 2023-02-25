Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == num1/num2)
{
Console.WriteLine("Первое число - это квадрат второго числа!");
}
else 
Console.WriteLine("Первое число - это не квадрат второго числа!");