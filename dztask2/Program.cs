// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные 
// буквы заменены на строчные.
// Пример:
// “aBcD1ef!-” => “abcd1ef!-”


Console.Write("Введите текст: ");
string st = Console.ReadLine()!;
Console.Write(st.ToLower());


// string st1 = "aBcD1ef!";
// Console.Write(st1.ToLower());