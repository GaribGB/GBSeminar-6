
Console.Clear();

string text = Input("Введите числа: ");
int result = 0;

for(int i = 0; i<text.Length; i++)
{
    if(text[i]=='0'||text[i]=='-')
    {
        for(int j = i+1; j<text.Length; j++)
        {
            if(text[j]==','||j+1==text.Length)
            {
                i = j;
                break;
            }        
        }
    }
    else if(text[i]!=' ')
    {
        result++;
        for(int j = i+1; j<text.Length; j++)
        {
            if(text[j]==','||j+1==text.Length)
            {
                i = j;
                break;
            }      
        }
    }
}

if (result>0)
{
    Console.WriteLine("Количество чисел больше 0: " + result);
}
else
{
    Console.WriteLine("В строке нет чисел больше 0");
}

string Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToString(Console.ReadLine());
}