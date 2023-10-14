using System.Text;
one();
two();
void one()
{
    char[] symb = new char[26] 
    {
    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 
    'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 
    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
    };
    Random rnd = new Random();
    string str = new string(Enumerable.Range(0, 10).Select(x => symb[rnd.Next(symb.Length)]).ToArray());
    char[] rev = str.ToCharArray();
    Array.Reverse(rev);
    string rev_str = new string(rev);
    Console.WriteLine(str);
    Console.WriteLine(rev_str);
}
void two()
{
    string time = "Текущее время 15:06:11";
    string date = "До нового учебного года осталось 03/01/03";
    Console.WriteLine(time);
    Console.WriteLine(date);
    Console.WriteLine(sort(time, ':'));
    Console.WriteLine(sort(date, '/'));
}

string sort(string str, char ch)
{
    str = string.Join("", str.Where(c => char.IsDigit(c)));
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < str.Length; i++)
    {
        sb.Append(str[i]);
        if ((i + 1) % 2 == 0 && i != str.Length - 1)
        {
            sb.Append(ch);
        }
    }
    str = sb.ToString();
    return str; 
}