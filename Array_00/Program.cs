// ============ МАСИВЫ

// void FillArray(int[] collection)   //  void-метод ничего не возвращает
// {
//     int length = collection.Length;  // нужно получить длинну массива
//     int index = 0;  // берем индек , по умолчанию - это "0"
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1,10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//   int count = col.Length;  //количество элементов
//   int position = 0; //позиция элемента массива(индекс)
//   while (position < count)
//   {
//     Console.WriteLine(col[position]); //конслоль печатает элементы перебирая индексы
//     position++;  // перебираем все позиции от 0 до "count"
//   }
// }

// int IndexOf(int[]collection, int find)
// {
//     int count = collection.Length; //определяем колличество элементов
//     int index = 0; //задаем стартовый индекс "0"
//     int position = -1; // если искомого элемента нет, то выдет  "-1", этой строкой заменили нижнюю строку, где был "0"
//     // int position = 0;// эта переменная задается вперед, сюда мы будем сохранять элемент массива, который совпал с faid
//     while (index < count)
//     {
//         if(collection[index] == find)
//         {
//             position = index;
//             break; //если нашелся нужный элемент, останавливаем работу
//         }
//         index++;
//     }
//     return  position; //после того как цикол отработал, нам возвращается позиция нужного элемента 
//     //!!!ВНИМАНИЕ после RETURN только пробел
// }

// int[] array = new int[10];  //  new int[10]  дословно значит - создай новый массив в котором будет 10 элементов
// FillArray(array);  //вызываем метод который создаем массив
// array[4] = 4; //принудительно добавляем искомые элементы
// array[7] = 4;
// PrintArray(array);  //метод, который печатает массив
// Console.WriteLine(); //выводим пустую строку

// int pos = IndexOf(array, 4); //вызываем метод
// Console.WriteLine(pos);

// =======Лекция 3
// Упорядовочрие данных внутри массмва:

int[]arr = {1,5,4,3,2,6,7};
// вывести массив на экран:
void PrintArray(int[] array) //метод печатанья массивов
 {
    int count = array.Length;  // обьявляем счетчик он равен длинне массива
    for (int i = 0; i < count; i++) // запускаем цикл, который печатает поэлементно массив в строку
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
 }
 // метод который упорядовацивает массив:
 
 void SelectionSort(int[] array)
   {
    for (int i = 0; i < array.Length - 1; i++) //обращение к длинне массива через "array.Length"
    {
      int minPosition = i;  
      
      for (int j = i+1; j < array.Length; j++)
      {
        if(array[j] < array[minPosition]) minPosition = j;
      }
      
      // это все происходит если исполнилось условие "if" эти три строки - обмен:
      int temporary = array[i];       //кладем рабочую позицию 
      array[i] = array[minPosition];  // 0(i) <-> 1(i+1)                
      array[minPosition] = temporary; // элемен, который больше перезаписался во временную переменную
    }
   }

 PrintArray(arr);
 SelectionSort(arr);
 PrintArray(arr);