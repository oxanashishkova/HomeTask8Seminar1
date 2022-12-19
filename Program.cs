// №6 На вход принимает число N, на выходе выдает четные числа от 1 до N


Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <= number)
{
    if (i % 2 == 0) { Console.Write($"{i} "); }
    i++;
}


