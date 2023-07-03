// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. 

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


System.Console.WriteLine("Введите:  ");
string? str = Console.ReadLine();
int count = str!.Length;
string[] arr = new string[count];

for (int i = 0; i < count; i++)
{
    arr[i] = Convert.ToString(str![i]); 
}

System.Console.WriteLine("[" + string.Join(", ", arr) + "]");