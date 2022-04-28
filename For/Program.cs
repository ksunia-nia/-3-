// See https://aka.ms/new-console-template for more information

string Method4(int count,string c)
{
        string result = String.Empty;// String.Empty пустая строка

        
    for ( int i =0;  i < count; i++)
    {
        result = result + c;
     }
    return result;
}

string res = Method4(5," подозрительно тихо(( ");
Console.WriteLine(res);