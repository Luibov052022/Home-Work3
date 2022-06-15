//Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int Koord(int x1, int x2)
{
    int rez = (x1-x2)*(x1-x2);
    return rez;    
}

int x1 = prompt("Введите х1: ");
int x2 = prompt("Введите x2: ");
int y1 = prompt("Введите y1: ");
int y2 = prompt("Введите y2: ");
int z1 = prompt("Введите z1: ");
int z2 = prompt("Введите z2: ");
double result = Math.Sqrt(Koord(x1,x2) + Koord(y1,y2) + Koord(z1,z2));
Console.WriteLine(result);


