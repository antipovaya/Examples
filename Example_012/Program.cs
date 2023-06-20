// Вид 1 Ничего не принимают и ничего не возвращают
void Method()
{
    Console.WriteLine("Автор ...");
}


Method();


// Вид 2 Что-то принимают но ничего не возвращают
/*
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст");

void Method21(string msg, int count){

    int i = 0;
    while (i < count){
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый Текст");

*/

// Вид 3 Что-то возвращают, но не принимают


int Method3 (){
    
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 Принимают и возвращают

// string Method4 (int count, string text){

//     int i = 0;
//     string result = String.Empty;
//      while (i < count){
//         result = result + text;
//         i++;
//      }
//      return result;

// }

string Method4 (int count, string text){

    
    string result = String.Empty;
     for (int i = 0; i < count; i++)
     {
        result = result + text;
       
     }
     return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


//Цикл в цикле на примере таблицы умножения

for (int i = 2; i <= 10; i++)
     {
        for (int j = 2; j <= 10; j++)
     {
        Console.WriteLine($"{i} * {j} = {i*j}");
     }
     Console.WriteLine(); // искуственный разрыв
     }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = “qwerty”
// 012345

// s[3] // r

// string Replase(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//         {
//             if(text[i] ==oldValue) result = result + $"{newValue}";
//             else result = result + $"{text[i]}";
//         }
//     return result;
// }
// string newText = Replase(text, ' ' , '|');
// Console.WriteLine(newText);


// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replase(text, 'к', 'К');
// Console.WriteLine(newText);


//Перераспределение массива от минимального к максимальному значению


int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
                    {
                        minPosition = j;
                    }
            }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);
