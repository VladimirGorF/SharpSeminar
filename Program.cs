
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

/*
Решение в группах задач:
Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное
 число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

int[]array = new int[12];
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-9, 10);
                if (i!=array.Length-1) Console.Write($"{array[i]}, ");
                else Console.WriteLine($"{array[i]}");
            }
        int x=Convert.ToInt32(Console.ReadLine());
        bool find=false;
        foreach (var item in array )
        {
            if (x==item)
            {
                find=true;
                break;
            }
        }

        if (find) Console.WriteLine("ДА");
        else  Console.WriteLine("НЕТ");
*/
/*
Задача 35: Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива,
 значения которых лежат в отрезке [3,10]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 15
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

int [] numbers = new int[15];
for(int i = 0; i < 15; i++)
{
    numbers[i] = new Random().Next(0,1000);
    if (i!=15-1)  Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}
Console.WriteLine();
int count = 0;
for (int i = 0; i < 15; i++)
{
    if (numbers[i]> 9 && numbers[i]<100)
    {
        count= count + 1;
    }
}
Console.WriteLine($"количество чисел от 10 до 100 : {count} .");


Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


int EvenNumCount()
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int [n];
    Console.WriteLine("Array");
    for (int i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(100,1000);
        Console.Write (Array[i]+ " ");
    }   
    Console.WriteLine();

    int count = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (Array[i]%2 == 0) 
        {
            count++;
        }
    }
    Console.WriteLine("count "+ count);
    Console.Write("");
    return count;
}  
try{
EvenNumCount();
}
catch
{
Console.WriteLine("Please use just integers");
}
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0


int EvenNumCount()
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] Array = new int [n];
    Console.WriteLine("Array");
    for (int i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(1,10);
        Console.Write (Array[i]+ " ");
    }   
    Console.WriteLine();

    int Sum = 0;
    for (int i=0; i<Array.Length; i++)
    {
        if (i%2 != 0) 
        {
            Sum += Array[i];
        }
    }
    Console.WriteLine("Sum of element of odd positions "+ Sum);
    Console.Write("");
    return Sum;
}  
try{
EvenNumCount();
}
catch
{
Console.WriteLine("Please use just integers");
}
*/



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
 элементом массива.
[3 7 22 2 78] -> 76


Первый вариант решения с 0.643657342658424682
double DiffMinMaxRealNum() 
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    double [] Array = new double [n];
    Console.WriteLine("Array:");
    Random rnd = new Random();
    int i = 0;
    for (i=0; i<Array.Length; i++)
    {
        Array[i] = rnd.NextDouble();
        Console.Write (Array[i]+ "  ");
    }   
    Console.WriteLine();

    double Min = 1;
    double Max = 0;
    for (i=0; i<Array.Length; i++)
    {
        if (Array[i] < Min)
        {
           Min = Array[i];   
        } 
        if (Array[i] > Max)
        {
            Max = Array[i];
        }
    }
    double Diff = Max - Min;
    Console.WriteLine("Difference between Min and Max = " + Diff);
    Console.WriteLine();
    return Diff;
}  
try{
    DiffMinMaxRealNum();
}
catch
{
   Console.WriteLine("Please use integer"); 
}

Второй  вариант решения с простыми числами!!!!!!!!!!!!!!!!!!!!!!!!!
double DiffMinMaxReal2Num() 
{
    Console.WriteLine("Please input a size of Array");
    int n = Convert.ToInt32(Console.ReadLine());
    double [] Array = new double [n];
    Console.WriteLine("Array:");

    int i = 0;
    for (i=0; i<Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 10);
        Console.Write (Array[i]+ "  ");
    }   
    Console.WriteLine();

    double Min = 10;
    double Max = 1;
    for (i=0; i<Array.Length; i++)
    {
        if (Array[i] < Min)
        {
           Min = Array[i];   
        } 
        if (Array[i] > Max)
        {
            Max = Array[i];
        }
    }
    double Diff = Max - Min;
    Console.WriteLine("Difference between Min and Max = " + Diff);
    Console.WriteLine();
    return Diff;
}  
try{
    DiffMinMaxReal2Num();
}
catch
{
   Console.WriteLine("Please use integer"); 
}
*/

/*****************************************************************************************************************************************
Задача 19 HARD - необязательная: Напишите программу, которая принимает на вход любое число и проверяет,
 является ли оно палиндромом.

void Palindrom()
{
    Console.WriteLine ("Please input a number:");
    int n = Convert.ToInt32(Console.ReadLine());
    int N = n;

    int count = 1;
    while (n/10 > 0 )
    {
        count++;
        n = n/10;
    }

    int [] Array = new int [count];
    for (int i = 0; i < Array.Length; i++)
    {
        Array [i] = N%10;
        N = N/10;
    }
    Console.WriteLine ();
        
    int TrueKey = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == Array[count-1])
        {
            count --;
        }   
        else  TrueKey=1;
    }
    if (TrueKey == 1) Console.WriteLine ( "Usual digit");
    else Console.WriteLine ("Palindrom");
}      
try 
{
    Palindrom();
}
catch
{
    Console.WriteLine ( "You should input integers only!");
}
*/

/*****************************************************************************************************************************************
Задача 21 HARD - необязательная
Напишите программу, которая принимает на вход целое положительное число N и координаты двух точек
 и находит расстояние между ними в N-мерном пространстве. 
double nDimSpace()
{
    Console.WriteLine("Please input a dimension of space");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] ArrayA = new int [n];
    Console.WriteLine("Please input coordinates of point A in space");
    for (int i=0; i<ArrayA.Length; i++)
    {
        ArrayA[i] = Convert.ToInt32(Console.ReadLine());
    }  
    int [] ArrayB = new int [n];
    Console.WriteLine("Please input coordinates of point B in space");
    for (int i=0; i<ArrayB.Length; i++)
    {
        ArrayB[i] = Convert.ToInt32(Console.ReadLine());
    }  
    double S =0; 
    double SumMathPow =0;   
    for (int i=0; i<ArrayA.Length; i++)
    {
        SumMathPow += Math.Pow(ArrayA[i]-ArrayB[i],2); 
        S = Math.Sqrt(SumMathPow);
    }
    return S;
}
try
{
 Console.WriteLine("Distance between A and B = " +nDimSpace());   
}
catch
{
Console.WriteLine("Please input correctly again!"); 
}
*/


/* Двухмерные массивы!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
string [,] table = new string[2,5];
table [1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/
/*****************************************************************************************************************************************
Двухмерный массив
void PrintArray(int [,]matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       Console.Write($"{matr [i,j]} ");
    }
Console.WriteLine();
}
}

void FillArray(int [,]matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [i,j] = new Random().Next(1,10);
    }
}
}

int [,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

****************************************************************************************************************************************
 Закраска массива

int [,] Pic = new int [,]
{
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0},
{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImag(int [,] imag)
{
for (int i = 0; i < imag.GetLength(0); i++)
{
    for (int j = 0; j < imag.GetLength(1); j++)
    {
       //Console.Write($"{imag [i,j]} ");
       if (imag[i,j] == 0) Console.Write($" ");
       if (imag[i,j] == 1) Console.Write($"+");
    }
Console.WriteLine();
}
}

void FiilImage(int row, int col)
{
if( Pic[row,col] == 0)
{
    Pic [row, col] = 1;
    FiilImage(row-1,col);
    FiilImage(row,col-1);
    FiilImage(row+1,col);
    FiilImage(row,col+1);
}
}
PrintImag(Pic);
FiilImage(6,13);
PrintImag(Pic);
*/
/*****************************************************************************************************************************************
double Factorial (int n)
{
if (n ==1) return 1;
else return n * Factorial(n -1);
}
Console.WriteLine(Factorial(5));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"число{i} + факториал{Factorial(i)}");
}
*/
/*
double fibonacci(int n)
{
if(n==1 || n==2) return 1;
else return fibonacci(n-1) + fibonacci(n-2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! + {fibonacci(i)}");
}
*/
/*****************************************************************************************************************************************
 Разворот массива
int n=9;
        void PrintArray(int[] arr)
            {
            for(int i = 0; i < n; i++)
                {     
                if (i!=arr.Length-1)  Console.Write($"{arr[i]}, ");
                else Console.WriteLine($"{arr[i]}"); 
                } 
            }

        int [] numbers = new int[n];
        for(int i = 0; i < n; i++)
            {
                numbers[i] = new Random().Next(0,100);
            }
        PrintArray(numbers);
        Console.WriteLine();
        int buf;
        for(int i = 0; i < n/2; i++)
           {
               buf = numbers[i];
               numbers[i] = numbers[n-1-i];
               numbers[n-1-i] = buf;
           }
        PrintArray(numbers);

*/
/*********************************************************************************************************************************************************************************
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
 ввёл пользователь.
5
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M),
 а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

int SumPositiv()
{
Console.WriteLine("Please input a numbers");
int [] Array = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
int Sum = 0;
for (int i = 0; i < Array.Length; i++)
{   
    if (Array[i] > 0) Sum += 1;
}
return Sum;
}

try 
{
   Console.WriteLine (SumPositiv());
}
catch
{
    Console.WriteLine ("Please input numbers separated by one space!");
}
*/
/********************************************************************************************************************************************************************************
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Coordinates()
{
    Console.WriteLine("Please input numer b1");
    double b1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer k1");
    double k1 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer b2");
    double b2 = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input numer k2");
    double k2 = Convert.ToDouble(Console.ReadLine()); 

    for (double x = -10.5; x <= 10.5; x++)
        {
            for (double y = -10.5; y <= 10.5; y++)
            {
                if ( y == k1 * x + b1 && y ==k2 * x + b2 )
                    Console.WriteLine($"Intersecton point X({x}, Y{y})");
            }
        }
}
try
{
   Coordinates(); 
}
catch
{
Console.WriteLine("Please input correctly");
}
*/
/* *******************************************************************************************************************************************************************************
задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
 Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию 
 по нему - площадь, периметр, значения углов треугольника в градусах, является ли он 
 прямоугольным, равнобедренным, равносторонним.

void TriangelPar()
{
    Console.WriteLine("Please input side a of the triangle");
    double a = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input side b of the triangle");
    double b = Convert.ToDouble(Console.ReadLine()); 
    Console.WriteLine("Please input side c of the triangle");
    double c = Convert.ToDouble(Console.ReadLine()); 
    
    if (a + b > c && a + c > b && b +c > a )
    {
        Console.WriteLine("This is triangle");
        double p = ( a + b + c ) / 2; // полупериметр
        double S = Math.Sqrt(p *(p - a) * (p - b) * (p - c));
        double P = p *2; //периметр

        if (a*a == c*c + b*b || b*b == a*a + c*c || c*c == a*a + b*b) Console.WriteLine("This is right triangle ");
        if ((a == b && a != c) || (a == c && a != b ) || (b == c && b != c)) Console.WriteLine("This is isosceles triangle");
        if (a == b && a == c) Console.WriteLine("This is equilateral triangle");

        Console.WriteLine($"S = {S}, P = {P}, ");
        Console.WriteLine ("Angles of triangle: ");
        Console.WriteLine("{0:F3}", Math.Acos((b*b + c*c - a*a) / (2*b*c)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((a*a + c*c - b*b) / (2*a*c)) * 180 / Math. PI);
        Console.WriteLine("{0:F3}", Math.Acos((a*a + b*b - c*c) / (2*a*b)) * 180 / Math. PI);
    } 
    else Console.WriteLine("This is not a triangle");
}
try
{
   TriangelPar(); 
}
catch
{
Console.WriteLine("Please input correctly");
}
*/
/******************************************************************************************************************
Задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
 Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно
  переместился на другое место (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций.
То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
*/

// Console.WriteLine("Please input m and n");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();


// int[,] matrix = new int[m, n];
// int[] ArrRandomI = new int[m];
// int[] ArrRandomJ = new int[n];   



// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void FillArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 100);
//         }
//     }
// }



// void RandomIndexJ(int[] ArrRandomJ)    //   Создал массив рандомных индексов J 
// {   
//     Console.Write($"Рандомные индексы: ");                                                                          
//     for (int i = 0; i < ArrRandomJ.Length; i++) ArrRandomJ[i] = -1;              // заполнил массив рандомных индексов "-1" вместо нулей
//     int l = new Random().Next(0, n);
//     for (int i = 0; i < ArrRandomJ.Length; i++)  
//     {
//         if (ArrRandomJ.Contains(l))
//         {
//             l = new Random().Next(0, n);
//             i--;
//         }
//         else
//         {
//             ArrRandomJ[i] = l;       // заполняем Рандомный массив для отсечения  повторных значений 
//             Console.Write($"{ArrRandomJ[i]}, ");
//         }
//     }
//     Console.WriteLine();
// }


// void RandomIndexI(int[] ArrRandomI)    //   Создал массив рандомных индексов J 
// {   
//     Console.Write($"Рандомные индексы: ");                                                                          
//     for (int i = 0; i < ArrRandomI.Length; i++) ArrRandomI[i] = -1;              // заполнил массив рандомных индексов "-1" вместо нулей
//     int k = new Random().Next(0, m);
//     for (int i = 0; i < ArrRandomI.Length; i++)  
//     {
//         if (ArrRandomI.Contains(k))
//         {
//             k = new Random().Next(0, m);
//             i--;
//         }
//         else
//         {
//             ArrRandomI[i] = k;       // заполняем Рандомный массив для отсечения  повторных значений 
//             Console.Write($"{ArrRandomI[i]}, ");
//         }
//     }
//     Console.WriteLine();
// }


// void ChangeArray(int[,] matrix)
// {   
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             int k = ArrRandomI[i];
//             int l = ArrRandomJ[i];
//             int Buff = matrix[i, j];
//             matrix[i, j] = matrix[k, l];
//             matrix[k, l] = Buff;
//             // Console.Write($"{matrix[i,j]}, ");
//         }
//         Console.WriteLine();
//     }
// }

// void GetNewArray(int[] ArrayOneRow)    // Из двухмерного создаю линейный массив ArrayOneRow[x]
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             int x = 0;
//             ArrayOneRow[x] = matrix[i, j];
//             Console.Write($"{ArrayOneRow[x]}     ");
//             x += 1;
//         }
//     }
//     Console.WriteLine();
// }


// void ChangeArray(int[] ArrayOneRow2)
// {                                                                             
//     for (int i = 0; i < ArrRandom.Length; i++) ArrRandom[i] = -1;              // заполнил массив рандомных индексов "-1" вместо нулей

//     int k = new Random().Next(0, m * n);
//     for (int i = 0; i < ArrRandom.Length; i++)  
//     {
//         if (ArrRandom.Contains(k) || (k == i && k == m*n-1))
//         {
//             k = new Random().Next(m * n);
//             i--;
//         }
//         else
//         {
//             if (k == i) k += 1;   // если индекс совпадает, то чтобы гарантированно не было пересечения, увеличиваем его на 1
//             ArrRandom[i] = k;       // заполняем Рандомный массив для отсечения  повторных значений
//             ArrayOneRow2[i] = ArrayOneRow[k]; // заполняем линейный Массив2 числами из массива ArrayOneRow выбираемыми по индексам из массива ArrRandom
//             Console.Write($"{ArrayOneRow2[i]},     ");
//         }
//     }
// //     Console.WriteLine();
// // }

// FillArray(matrix);
// PrintArray(matrix);
// RandomIndexI(ArrRandomI);
// RandomIndexJ(ArrRandomJ);
// ChangeArray(matrix);
// PrintArray(matrix);
// // GetNewArray(ArrayOneRow);
// // ChangeArray(ArrayOneRow2);
// Console.WriteLine();


/*****************************************************************************************************************
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Console.WriteLine("Please input m and n");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] Array = new double[m, n];

// void PrintArray(double[,] Matrix)
// {
//     for (int i = 0; i < Matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < Matrix.GetLength(1); j++)
//         {
//             Console.Write($"{Matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int m, int n)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             double x = rnd.NextDouble() * 100;
//             Array[i, j] = Math.Round(x, 1);
//         }
//     }
// }

// try
// {
//     FillArray(m, n);
//     PrintArray(Array);
//     Console.WriteLine();
// }
// catch
// {
//     Console.WriteLine("Please use integers only");
// }

/*****************************************************************************************************************
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

try
{
Console.WriteLine("Please input m and n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input x");
int x = Convert.ToInt32(Console.ReadLine()); ;
int[,] Array = new int[m, n];
Console.WriteLine();

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().Next(1, 10);
        }
    }
}

int CheckArray(int[,] Array)
{
    int Element = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == x)
            {
                Element = x;
            }
        }
    }
    if (Element == 0) Console.WriteLine($"{x} ->  this integer is absent");
    else Console.WriteLine(Element);
    return Element;
}

FillArray(Array);
PrintArray(Array);
CheckArray(Array);
Console.WriteLine();

}
catch
{
    Console.WriteLine("Pease input correctly");
}
*/
// *********************************************************************************************************************

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Array = new int[,]
// {
//  {1, 4, 7, 2},
//  {5, 9, 2, 3},
//  {8, 4, 2, 4}
// };

// double[] ArrResault = new double[4];

// void ArithmeticMeanColumn(int[,] Array)
// {
//     double Res = 0;
//     Console.WriteLine("Срееднее арифметическое кадого столбца: ");
//     for (int j = 0; j < Array.GetLength(1); j++)
//     {
//         for (int i = 0; i < Array.GetLength(0); i++)
//         {

//             Res = Res + Array[i, j];

//         }
//         Res = Res / 3;
//         Res = Math.Round(Res, 1);
//         ArrResault[j] = Res;
//         Res = 0;
//     }
// }

// void PrintArrResult()
// {
//     for (int i = 0; i < ArrResault.Length - 1; i++)
//     {
//         Console.Write($"{ArrResault[i]},  ");
//     }
//     Console.Write($"{ArrResault[ArrResault.Length - 1]}.");
// }

// ArithmeticMeanColumn(Array);
// PrintArrResult();
// Console.WriteLine();

// /*********************************************************************************************************************
// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

try
{
    Console.WriteLine("Please input m and n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] Array = new int[m, n];
    int[] ArrayOneLine = new int[m * n];

    void PrintArray()
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Console.Write(Array[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    void FillArray()
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = new Random().Next(1, 10);
            }
        }

    }

    void FillOneLineArray()
    {
        int k = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                ArrayOneLine[k] = Array[i, j];
                k += 1;
            }
        }
    }

    void BubbleSort(int[] Array)
    {
        for (int i = 0; i < ArrayOneLine.Length; i++)
        {
            for (int j = 0; j < ArrayOneLine.Length - 1; j++)
            {
                if (ArrayOneLine[j] > ArrayOneLine[j + 1])
                {
                    int temp = ArrayOneLine[j];
                    ArrayOneLine[j] = ArrayOneLine[j + 1];
                    ArrayOneLine[j + 1] = temp;
                }
            }
        }
    }

    void FillSortArray(int[,] Array)
    {
        int k = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = ArrayOneLine[k];
                k++;
            }
        }
    }

    FillArray();
    PrintArray();
    FillOneLineArray();
    BubbleSort(ArrayOneLine);
    FillSortArray(Array);
    PrintArray();
}
catch
{
    Console.WriteLine("Please input correctly");
}




// ********************************************************************************************************************
// Задача про библиотеку чисел.


// Console.WriteLine("Please input m and n");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [,] table = new int [m,n];
// int [] Array = new int [10];

// void FillArray(int[,] table)
// {
//     Random random = new Random();
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = random.Next(1,10);
//         }
//     }
// }

// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Dictionary(int[,] table) 
// {

//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Array [ table [i,j]] ++;
//             Console.Write($"{Array[i]}, ");
//         }
//     }
// }


// FillArray(table);
// PrintArray(table);
// Dictionary(table);

