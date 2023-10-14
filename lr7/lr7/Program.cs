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
    char space = ' ';
    for (int i = 0; i < symb.Length; i++)
    {
        if (symb[i] == space)
        {
            int a = i + 1;
            if (symb[a] == space)
                n--;
            else symb2[i] = symb[i];
        }
        else symb2[i] = symb[i];
    }
    string result = new string(symb2);
    result = result.Replace("+", "плюс");
    result = result.Replace("-", "минус");
    result = result.Replace("*", "умножить");
    result = result.Replace("/", "делить");
    Console.WriteLine(result);
}
void three()
{
    string str = "дгвба*абвгд";
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
    if (str1.All(c => str2.Contains(c)) || str2.All(c => str1.Contains(c)))
        Console.WriteLine(true);
    else Console.WriteLine(false);
}