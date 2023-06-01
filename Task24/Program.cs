// See https://aka.ms/new-console-template for more information
//Программа принимает на ввод число А и выдает сумму от 1 до А (метод)
int GetSum(int n){
int sum = 0;
for (int i=1; i<=n; i++)
sum +=i;// == sum = sum + i
return sum;
}
Console.Clear();
Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine($"{GetSum(Number)}");
