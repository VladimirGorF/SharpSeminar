
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

/*
try
            {
            Console.Write("Введите координату х ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y ");
            int y = int.Parse(Console.ReadLine());  
            int res;
            if ( x>0 && y>0 )   res=1;
            else if ( x<0 && y>0 )   res=2;
            else if ( x<0 && y<0 )   res=3;
            else if ( x>0 && y<0 )   res=4; 
            else res=0;  
            Console.WriteLine(res);
            }
        catch
            {
            Console.WriteLine("Надо было вводить именно числа, и именно целые!");    
            }

*/
/*
int GetNum4()
        {
            Console.Write("Введите координату х ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату y ");
            int y = int.Parse(Console.ReadLine());  
            int res;
            if ( x>0 && y>0 )   res=1;
            else if ( x<0 && y>0 )   res=2;
            else if ( x<0 && y<0 )   res=3;
            else if ( x>0 && y<0 )   res=4; 
            else res=0; 
            return res;
        }
        
        try
            {
            Console.WriteLine(GetNum4());
            }
        catch
            {
            Console.WriteLine("Надо было вводить именно числа, и именно целые!");    
            }

*/
/*
Задача 18: Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*Задача 21: Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));   
        return S;
     }
try
{
    
     Console.WriteLine(Res());
            
}
catch
{
    Console.WriteLine("введите цифры");
}

Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write(i*i+", ");
}
*/

//Задача 22: Напишите программу, которая
//    принимает на вход число (N) и выдаёт
//    таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
/*
void SquareTableN()
{
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] answer = new int[N];
    if (N > 0)
    {
        for (int i = 1; i < (N + 1); i++)
        {
            answer[i - 1] = (i * i);
        }
    }
    else
        {
            Console.Write("Надо было вводить положительные числа");
        }
    var str = string.Join(" ", answer);
    Console.WriteLine(str);
}

try
{
    SquareTableN();
}
catch
{
    Console.Write("Надо было вводить числа");
}

*/
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
/*
void Palindrom()
{
Console.WriteLine ("Please input a five-digit number:");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = x/10000;
int x2 = (x/1000)%10;
int x4 = (x/10)%10;
int x5 = x%10;

if (x1 == x5 && x2 == x4) Console.WriteLine ( "Palindrom"); 
else  Console.WriteLine ( "Usual digit");
}
try 
{
    Palindrom();
}
catch
{
Console.WriteLine ( "you should input five-ditits only");
}
*/
/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
double Res () 
     {
       Console.WriteLine("Введите координаты точки A (x;у;z) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        int Az=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите координаты точки B (x;у;z) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());
        int Bz=Convert.ToInt32(Console.ReadLine());

        int x =Ax-Bx;
        int y = Ay-By;
        int z = Az-Bz;
        double S = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));   
        return S;
     }
try
{
    
     Console.WriteLine(Res());
            
}
catch
{
    Console.WriteLine("введите цифры");
}
*/
/*
Задача 23 
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

try
{
void Cube()
{
Console.WriteLine ("Please input a number");
int n = Convert.ToInt32 (Console.ReadLine());
for (int i = 1; i <= n; i++  ) Console.Write("Cube: "+Math.Pow(i,3)+ ", ");
}
Cube ();
}
catch
{
Console.WriteLine("не порите чужжжжжж");
}
*/

/* Задача необязательная
Напишите программу, которая считывает с консоли числа (по одному в строке)до тех пор, пока сумма введённых чисел не будет равна 0 и сразу
 после этого
  выводит сумму квадратов всех считанных чисел. Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, 
после этого считывание продолжать не нужно. В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем,
 что сумма этих чисел равна нулю и выводим сумму их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.*/
/*
int SumSquareNumbers ()
{
Console.WriteLine("Please input a number");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = N;
int SumSquare = N*N;

do
{
Console.WriteLine("Please input a number");
N = Convert.ToInt32(Console.ReadLine());
Sum = Sum + N;
SumSquare = SumSquare + N*N;
}
while (Sum !=0);
Console.WriteLine();
return SumSquare;
}

try
{
Console.WriteLine("Sum of squares of all numbers: " + SumSquareNumbers());   
}
catch
{
Console.WriteLine("не порите чужжжжжжжжь");
}

*/
/*
string WordEnd(int n)
{
    int n100 = n%100;
    int n10 = n%10;
    if (n100>=5 & n100<=20) return "ов";
    else if (n10==1) return "";
    else if (n10>=2 & n10<=4) return "а";
    else if (n10>=5 ^ n10==0)  return "ов";
    else return "";
}

Console.Write("Введите сколько программистов в комнате: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В комнате " + n + " программист" + WordEnd(n));
*/
/*
Console.Write("введите ваше имя ");
        string name = Console.ReadLine();
 
        switch (name)
            {
            case "Bob":
                Console.WriteLine("Здарова, Bob");
                break;
            case "Tom":
                Console.WriteLine("Привет, Tom");
                break;
            case "Sam":
                Console.WriteLine("Как дела, Sam");
                break;
            default:
                Console.WriteLine("Приятно познакомиться, "+name);
                break;
            } */
/*
Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный случайными целыми числами. 
N - целое число и задается с клавиатуры.*/

/*

Console.WriteLine("Введите целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [] numbers = new int[n];
        for(int i = 0; i < n; i++)
            {
                numbers[i] = new Random().Next(1,100);
                if (i!=n-1)  Console.Write($"{numbers[i]}, ");
                else Console.WriteLine($"{numbers[i]}");
            }
*/
/*
Задание - 1 уровень - найти максимальное число и его индекс, найти минимальное
 число и его индекс, найти среднее арифметическое, 2 уровень - обернуть в функцию
*/
/*
Console.WriteLine("Введите целое число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [] numbers = new int[n];
        for(int i = 0; i < n; i++)
            {
                numbers[i] = new Random().Next(1,100);
                if (i!=n-1)  Console.Write($"{numbers[i]}, ");
                else Console.WriteLine($"{numbers[i]}");
            }



*/
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
/*
int NaturalDegreeA()
{
Console.WriteLine("Please input number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input degree");
int B = Convert.ToInt32(Console.ReadLine());
int ND = A;

for (int i = 0; i < B-1; i++ ) ND = ND*A;

return ND;
}
Console.WriteLine(NaturalDegreeA()); 


Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 

int SumOfDiggits()
{
Console.WriteLine("Please input number A");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
for(int i = 0; A > 0; i++) 
{
    Sum = Sum + A%10;
    A = A/10;
}
return Sum; 
}
try { 
Console.WriteLine("Sum of digits of number is: " + SumOfDiggits());
}
catch 
{
Console.WriteLine("Please input number A correctly");
}


Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


int [] Array = {1,2,3,4,5,6,7,8};
for (int i = 0; i<8; i++) Console.WriteLine($"{Array[i]}");
*/
/*
необязательная задача Написать программу сортировки массива от большего к меньшему.
 Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
*/

/*
int [] Array = {2, 6, 8, 9, 3};

void ArrInput (int [] Array)
{
    int count = Array.Length;
    for(int i = 0; i < count; i++)
{
    Console.Write(Array[i] + " ");  
}
    Console.WriteLine(); 
}

void ArraySorting(int [] Array)
{
    for (int i = 0; i<Array.Length - 1; i++)
    {
        int maxPos = i;
        
        for (int j = i+1; j<Array.Length; j++)
        {
            if (Array [j] > Array [maxPos])  maxPos = j;
          
        }
        int Temp = Array[i];
        Array [i] = Array [maxPos];
        Array [maxPos] = Temp; 
         
    }
}

ArrInput(Array);
ArraySorting(Array);

ArrInput(Array);
*/
/*
Console.WriteLine("Please input a number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Array :");
int [] Array = new int [n];

void ArrInput (int [] Array)
{
    int count = Array.Length;
    for(int i = 0; i < count; i++)
    {
        Array [i] = new Random().Next(1,10);
        Console.Write(Array[i] + " "); 
    }
    Console.WriteLine(); 
}

void ArraySorting(int [] Array)
{
    for (int i = 0; i<Array.Length - 1; i++)
    {
        int maxPos = i;
        
        for (int j = i+1; j<Array.Length; j++)
        {
            if (Array [j] > Array [maxPos])  maxPos = j;
          
        }
        int Temp = Array[i];
        Array [i] = Array [maxPos];
        Array [maxPos] = Temp; 
         
    }
}

ArrInput(Array);
ArraySorting(Array);

ArrInput(Array);
*/

/*
string Text =     "The default interactive shell is now zsh."
                + "To update your account to use zsh, please run `chsh -s /bin/zsh`."
                + "For more details, please visit https://support.apple.com/kb/HT208050."
                + "iMac-Vladimir:SharpSeminar vladimirgorbunov$";

string  Replace (string Text, char oldValue, char newValue)
{
string result = string.Empty;
int length = Text.Length;
for (int i = 0; i < length; i++)
{
    if (Text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{Text[i]}";
}

return result;
}

string NewText = Replace(Text,' ', '!' );
Console.WriteLine(NewText);

Console.WriteLine();

string NewText2 = Replace(Text,'s', 'S' );
Console.WriteLine(NewText2);
*/




