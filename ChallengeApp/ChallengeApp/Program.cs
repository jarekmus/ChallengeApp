// zadanie dzień 5

int number = 5673674;
string numberAsString = number.ToString();
char[] chars = numberAsString.ToCharArray();
Console.WriteLine("W dzisiejszym losowaniu padły następujące liczby");

for (var i = 0; i < 10; i++)
{
    var counter = 0;
    foreach (char a in chars)
    {
        string iString = i.ToString();
        string aString = a.ToString();
        if (aString == iString)
        {
            counter++;
        }
    }
    Console.WriteLine(i + " => " + counter);
}