
/* Программа удаления второго числа из трехзначного*/
/*
void PrintDigit()   
{

Console.WriteLine("x");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x/100;
int x2 = x%10;
Console.WriteLine(x1+""+x2);
}
PrintDigit();
*/


/* 
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли наименьшее число кратным наибольшему.
 Если  наибоьшее не кратно наименьшему, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно



Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a >= b)
{
    if (a%b == 0) Console.WriteLine("кратно");
    else Console.WriteLine("не кратно, остаток " + a%b);
}
else 
{
    if (b%a == 0) Console.WriteLine("кратно");
    Console.WriteLine("не кратно, остаток " + b%a);
}
*/



/*
Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

string Multiplicity(int num1, int num2)
{
    string multiplicity = String.Empty;
    int max = num1;
    int min = num2;
    
    if (num2 > num1)
    {
        max = num2;
        min = num1;
    }

    if (max % min == 0)
    {
        multiplicity = $"Число {max} кратно {min}";
    }
    else
    {
        multiplicity = $"Число {max} не кратно {min}, остаток {max % min}";
    }

    return multiplicity;
}
Console.WriteLine(Multiplicity(number1, number2)); */



































