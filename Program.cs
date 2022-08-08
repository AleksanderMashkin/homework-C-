/* Console.WriteLine("Введите первое число");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int min = Convert.ToInt32(Console.ReadLine());
if (max > min)
{
   Console.WriteLine(max + "-большее число");
   Console.WriteLine(min + "-меньшее число");
   
}
else
{
   Console.WriteLine(min + "-большее число");
   Console.WriteLine(max + "-меньшее число");
} */



/* int max = 0;
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
   max = number1;
}
else
{
   max = number2;
}
if (max>number3)
{
   Console.WriteLine(max + "-наибольшее число");
}
else
{
   Console.WriteLine(number3 + "-наибольшее число");
} */

/* Console.WriteLine("Введите число");
int number=Convert.ToInt32(Console.ReadLine());
int checkout = number % 2;
Console.WriteLine(checkout);
if (checkout == 0)
{
   Console.WriteLine("Да");
}
else
{
   Console.WriteLine("Нет");
}   */



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int i = number;
while (number>0)
{
 if (number % 2 == 0)
 {
   Console.WriteLine(number);
   number--;
 }  
 else
 {
   number--;
 }
}