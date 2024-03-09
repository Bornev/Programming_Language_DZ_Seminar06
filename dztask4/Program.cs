// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.


void PrintNewStringArray(string[] words)
{
  for (int i = words.Length - 1; i >= 0; i--)
  {
    Console.Write(" ");
    if (i > 0)
    {
      Console.Write(" ");
    }
    Console.Write(words[i]);
  }
}

Console.Write("Введите строку: ");
string InputString = Console.ReadLine()!;
string[] words = InputString.Split(' '); 
PrintNewStringArray(words); 






















// вар 1

// Пример:
// “Hello my world” => “world my Hello”

// char[] StriingOfcharArray(string[] newString)
// {
//     char[] arr = new char[newString.Length];
//     for (int index = 0; index < newString.Length; index++)
//     {
//         arr[index] = newString[index];
//     }
//     return arr;
// }
// void PrintNewStringArray(char[] arr)
// {
//     // string temp = arr[0];
//     for (int i = arr.Length - 1; i >= 0; i--)
//  {
//         if (i > 0)
//         {
//             Console.Write(" ");
//         }
//         Console.Write(arr[i]);
//     }
// }



// Console.Write("Введите строку: ");
// string InputString = Console.ReadLine()!;
// string[] words = inputString.Split(' ');
// PrintNewStringArray(StriingOfcharArray(words));




// вар 2


// string[] StriingOfcharArray(string[] newString)
// {
//     string[] arr = new string[newString.Length];
//     for (int index = 0; index < newString.Length; index++)
//     {
//         arr[index] = newString[index];
//     }
    // return arr;
// }




















