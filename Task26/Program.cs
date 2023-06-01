// See https://aka.ms/new-console-template for more information
/*int GetSum(int n){
int sum = 0;
for (int i=1; i<=n; i++)
sum +=i;// == sum = sum + i
return sum;
}*/
//// 26 Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
int Count(int n){
    int count = 1;
while (n/10>0||n/10<0){
count = count + 1;
n /=10;
}
return count;
}
System.Console.WriteLine("Введите число");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine($"{Count(Number)}");
