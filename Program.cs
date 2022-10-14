const int limit = 3;

string source = 
    "Я попугай с антильских островов\r\n" + 
    "Но я живу в квадратной келье мага\r\n" +
    "Вокруг реторты глобусы бумага\r\n" +
    "И кашель старика и бой часов";

string[] sourceArray =  source.Replace("\r\n", " ").Split(new char[] {' '});
string[] resultArray = Processing(sourceArray);

PrintResults();

# region methods

string[] Processing(string[] array)
{    
    string[] result = new string[0];
    
    foreach (string elem in array)
    {
        if (elem.Length <= limit)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length-1] = elem;            
        }
    }

    return result;
}

void PrintResults()
{ 
    string resultStr = "[";

    foreach (string str in sourceArray)
    {
        resultStr = string.Concat(resultStr, "\"", str, "\",");    
    }
    
    resultStr = string.Concat(resultStr.Substring(0, resultStr.Length-1), "]");

    if (resultArray.Length > 0)
    {
        resultStr = string.Concat(resultStr, " -> ");

        foreach (string str in resultArray)
        {
            resultStr = string.Concat(resultStr, "\"", str, "\",");
        }

        resultStr = resultStr.Substring(0, resultStr.Length-1);
    }
    
    Console.WriteLine(resultStr);
}

#endregion