// See https://aka.ms/new-console-template for more information
/*//28 Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5*/
int Product(int n){
    int product = 1;
    for (int i = 2; i<=Math.Abs(n); i++)
        product = product*i;
    return product;
}
int Number(){
Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
return number;
}
int number = Number();
System.Console.WriteLine($"Произведение {number} чисел = {Product(number)}");
