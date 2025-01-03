// See https://aka.ms/new-console-template for more
// 

using Arrays;

CustomArray<int> array = new CustomArray<int>(2);

array.Add(1);
array.Add(2);

foreach(var item in array)
{
    Console.WriteLine(item);
}