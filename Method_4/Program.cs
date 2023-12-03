// Методы (продолжение)
    //Вид 1 -Ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор Марина");
}
Method1();   //вызываем метод

     //Вид 2 - Принимают значение ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");   //вызываем метод
              //еще вариант этого типа:

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Тест", 4);              // вызов метода 
Method21(msg: "Текст новый", count: 3); // другой способ вызова метода  с именованаными аргументами

       //Вид 3 -  не принимают значение но возвращает возвращают

int Method3()
{
    return DateTime.Now.Year;  // обязательно оператор "return"
}
int year = Method3();         // вызов метода, через переменную, которую мы получаем вызывая метод
Console.WriteLine(year);

       //Вид 4 -  и принимают значение и возвращает возвращают 
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // это пустая строка
    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, " TEXT ");
Console.WriteLine(res);

// ЦИКЛ FOR

string Method5(int count, string text)
{

    string result = String.Empty; 
    for (int i = 0; i < count; i++) // Все условия проверки все указано в скобках 
    {
        result = result + text;
    }
    return result;
}
string ress = Method5(12, " e3e4e,");
Console.WriteLine(ress);