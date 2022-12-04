// Из имеющегося массива строк сформировать массив строк, длика которых меньше либо равна 3 символам.

Console.Clear();

string[] MassOnlySmallString(string[] ar)
{
    List <string> result = new List<string>();
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length<=3){
            result.Add(ar[i]);
        }
    }
    string [] massForOut=result.ToArray<string>();
    return massForOut;
}

string[] startMass = new string[4] { "Один", "Два", "Три", "00" };
string[] resMass = MassOnlySmallString(startMass);

Console.WriteLine(String.Join(", ", resMass));