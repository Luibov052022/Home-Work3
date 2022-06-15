// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int prompt(string message)
{
Console.Write(message);
string number = Console.ReadLine();
int numberInt = int.Parse(number);
return numberInt;
}

int numberInt = prompt("введите число: ");
int Count = (int)Math.Log10(numberInt) + 1;
int [] array = new int[Count];
int index = array.Length - 1;

while (numberInt > 0)
{
    array[index] = numberInt % 10;
    numberInt = numberInt / 10;
    index--;
}

int a= 0;

for(int i = 0; i < (array.Length/2); i++)
{
   if(array[i] == array[Count - i -1])
   {
        a++;
   }
}

if (array.Length/2 == a)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}



