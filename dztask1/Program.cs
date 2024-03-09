// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
// Пример:
// a b c => “abcdef”
// d e f 

string CharsOfString(char[,] arr)
{
    string st= "";
    for (int rowIndex = 0; rowIndex < arr.GetLength(0); rowIndex++)
{
    for (int columnIndex = 0; columnIndex < arr.GetLength(1); columnIndex++)
{
    st +=arr[rowIndex,columnIndex];
}
}
//  foreach (var item in arr)  // тоже работает
//  {
//     st +=item;
//  }
return st;
}



char[,] chars=new char[,] 
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
Console.Write(CharsOfString(chars));