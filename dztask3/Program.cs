// Решение через массив
// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

// using System.Text;
// char[] StriingOfcharArray(string newString)
// {
//     char[] arr = new char[newString.Length];
//     for (int index = 0; index < newString.Length; index++)
//     {
//         arr[index] = newString[index];
//     }
//     return arr;
// }

// // void PrintCharArray(char[] arr)                 // для отладки
// // {
// //     foreach (char item in arr)
// //     {
// //         Console.Write($"'{item}'");
// //     }
// // }

// bool IsCheckingPolyndromes(char[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         if (arr[i] != arr[arr.Length - 1 - i])
//         {
//             return false;
//         }
       
//     }
//     return true;
// }

// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;
// Console.Write("Введите строку: ");
// string InputString = Console.ReadLine()!;
// char[] array = StriingOfcharArray(InputString);
// // PrintCharArray(array);                       // для отладки
// if (IsCheckingPolyndromes(array))
// {
//     Console.Write("Да");
// }

// else
// {
//     Console.Write("Нет");
// }








// решение через строк


// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

using System.Text;

bool IsCheckingPolyndromes(string Input)
{
    for (int i = 0; i < Input.Length / 2; i++)
    {
        if (Input[i] != Input[Input.Length - 1 - i])
        {
            return false;
        }      
    }
    return true;
}

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Console.Write("Введите строку: ");
string InputString = Console.ReadLine()!;

if (IsCheckingPolyndromes(InputString))
{
    Console.Write("Да");
}

else
{
    Console.Write("Нет");
}