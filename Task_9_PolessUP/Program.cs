int[] years = {44, 2015 };
Console.WriteLine("Ввод:\t" + string.Join("\t", years));
Console.Write("Вывод:");
foreach (var year in years)
{
    Console.Write("\t" + LeapYearCheck(year));
}

bool LeapYearCheck(int year)
{
    if (year % 4 != 0)
    return false;
    else if (year % 100 != 0)  return true;  
    else if (year % 400 == 0)  return true; 
    else return false; 
}