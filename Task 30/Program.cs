//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
// Console.WriteLine($"a = {a},b = {b}");
int Number(){
Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
return number;
}
int [] Array_Random(int n)
{
    int [] array = new int[n];
    for ( int i = 0; i<n; i++)
        array[i] = new Random().Next(0,2);
       return array;
}
void Print_Array(int [] array){
    for (int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
}
int number = Number();
int [] array = Array_Random(number);
Print_Array(array);
Console.WriteLine();





