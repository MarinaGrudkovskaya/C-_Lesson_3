// ЦИКЛ FOR

// string Method5(int count, string text)
// {

//     string result = String.Empty; 
//     for (int i = 0; i < count; i++) // Все условия проверки все указано в скобках 
//     {
//         result = result + text;
//     }
//     return result;
// }
// string ress = Method5(12, " e3e4e,");
// Console.WriteLine(ress);

//========Цикл внутри цыкла

// for (int i = 2; i <=10; i++)
// {
//     for (int j = 0; j <=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j};"); //тело внутреннего цикла.
//     }
//     Console.WriteLine();  // прежде чем зайти на новую  "i" ставится пустая строка
// }

// ========Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
 //            012345
 // s[3]  // r

 string Replace(string text, char oldValue, char newValue)
 {
    string result = String.Empty;   //Сразу ввели переменную - пустую строку

    int length = text.Length; //ввели длину строки, если запросим строку из 38 позиции вернет 6
    for (int i = 0; i < length; i++) //цикл пробегается от нулевого элемента до конца строки +1
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
        
    }
    return result;   //сразу указали что возвращаем
 }
 string newText = Replace(text, ' ', '|');

 Console.WriteLine(newText);
 Console.WriteLine();
 newText = Replace(newText, 'к', 'К');
 Console.WriteLine(newText);
 newText = Replace(newText, 'с', 'S');
 Console.WriteLine(newText);