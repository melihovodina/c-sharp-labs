using System.Text;
using System.Linq;
using System.Globalization;

one();
two();
three();
four();
void one()
{
    string str = Console.ReadLine();
    string[] words = str.Split(' ');
    int sharps_num = 0;
    int comp_num = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if (words[i] == "Pascal")
        {
            words[i] = "C#"; sharps_num++;
        }
        if (words[i] == "компьютер")
            comp_num++;
    }
    str = string.Join(" ", words);
    Console.WriteLine(str);
    Console.WriteLine($"Кол-во слова Pascal: {sharps_num}");
    Console.WriteLine($"Кол-во слова компьютер: {comp_num}");
}
void two()
{
    string str = Console.ReadLine();
    StringBuilder symb = new StringBuilder(str);
    int n = symb.Length;
    char[] symb2 = new char[n];
    for (int i = 0; i < symb.Length; i++)
    {
        if (symb[i] == ' ')
        {
            int a = i + 1;
            if (symb[a] == ' ')
                n--;
            else symb2[i] = symb[i];
        }
        else symb2[i] = symb[i];
    }
    str = new string(symb2);
    str = str.Replace("+", "плюс");
    str = str.Replace("-", "минус");
    str = str.Replace("*", "умножить");
    str = str.Replace("/", "делить");
    Console.WriteLine(str);
}
void three()
{
    string str = "дгвба*абвгд";
    Console.WriteLine(str);
    int index = str.IndexOf('*');
    if(index != -1)
    {
        string sort = String.Concat(str.Substring(0, index).OrderBy(x=>x));
        str = sort + str.Substring(index);
    }
    Console.WriteLine($"Индекс: {index}");
    Console.WriteLine($"Строка: {str}");
    
}
void four()
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();
    string[] words1 = str1.Split(' ');
    string[] words2 = str2.Split(' ');
    for (int i = 0; i < words1.Length; i++)
    {
        if (words1[i] == "компьютер")
            words1[i] = "";
    }
    for (int i = 0; i < words2.Length; i++)
    {
        if (words2[i] == "компьютер")
            words2[i] = "";
    }
    str1 = string.Join(" ", words1);
    str2 = string.Join(" ", words2);
    Console.WriteLine(str1);
    Console.WriteLine(str2);
    if (str1.All(c => str2.Contains(c)) || str2.All(c => str1.Contains(c)))
        Console.WriteLine(true);
    else Console.WriteLine(false);
}