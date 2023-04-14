//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Введите первое число "); 
string s = Console.ReadLine();                     
int i = int.Parse(s);

System.Console.WriteLine("Введите второе число "); 
string t = Console.ReadLine();
int j = int.Parse(t);

System.Console.WriteLine("Введите третье число "); 
string e = Console.ReadLine();
int k = int.Parse(e);

int max = 0;

if (max < i)
{
    max = i;
}

if (max < j)
{
    max = j;
}

if (max < k)
{
    max = k;
}

System.Console.WriteLine($"Максимальное число : {max}");