// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int Count(string[] array, int maxElem)
{
  int count = 0;
  for(int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= maxElem) count++;
  }
  return count;
}

void FillArray(string[] array1, string[] array2, int maxElem)
{
  int j = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if(array1[i].Length <= maxElem)
    {
      array2[j] = array1[i];
      j++;
    }
  }
}
Console.Clear();
Console.WriteLine("Введите массив через пробел");
string[] arrayFirst = Console.ReadLine().Split(" ").ToArray();
Console.WriteLine($"Первый массив: [{string.Join(", ", arrayFirst.Select(x => '"' + x + '"'))}]");
Console.WriteLine("Введите максимальную длинну элемента массива");
int maxElem = Convert.ToInt32(Console.ReadLine());
int size = Count(arrayFirst, maxElem);
string[] arraySecond = new string[size];
FillArray(arrayFirst, arraySecond, maxElem);
Console.WriteLine($"Второй массив: [{string.Join(", ", arraySecond.Select(x => '"' + x + '"'))}]");

