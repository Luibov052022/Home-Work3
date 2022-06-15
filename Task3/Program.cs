//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int N = prompt("Введите число: ");
int i = 1;

for (i = 1; i < (N+1); i++)
{
    double resit = Math.Pow(i,3);
    Console.Write($"{resit}, ");
}

