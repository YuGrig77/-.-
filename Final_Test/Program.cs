//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();

string[] words = { "Hello", "I", "soon", "am", "1234", "web" };
string[] words_to_choose = new string[words.Length];

void ChoosenWordsIf(string[] words, string[] words_to_choose)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            words_to_choose[count] = words[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ChoosenWordsIf(words, words_to_choose);
PrintArray(words_to_choose);