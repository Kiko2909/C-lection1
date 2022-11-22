// Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к» заменить большими «К», 
//а большие «С» заменить на маленькие «с».

string text = "— Я думаю, — сказал князь, улыбаясь, — что" + "ежели бы вас послали вместо нашего милого Винценгероде" + "вы бы взяли приступом согласие прусского короля." + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwety"
// .           01234
//s[3] // r

string Replace (string text, char OldValue, char NewValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == OldValue) result = result + $"{ NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');


NewText = Replace(NewText, 'к', 'К');


NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);