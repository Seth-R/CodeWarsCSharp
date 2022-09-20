//I will give you an integer. Give me back a shape that is as long and wide as the integer. The integer will be a whole number between 1 and 50.
var n = Console.ReadLine();
string tab = "";
for (int i = 0; i < Convert.ToInt32(n); i++)
{
    for (int j = 0; j < Convert.ToInt32(n); j++)
    {
        tab += "+";
    }
    if (i < (Convert.ToInt32(n) - 1))
    {
        tab += "\n";
    }

}
Console.WriteLine(tab);