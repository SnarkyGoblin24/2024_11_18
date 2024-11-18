using ConsoleApp1;
using System.Runtime.ConstrainedExecution;
using System.Text;


List<Berek> list = new List<Berek>();

using StreamReader sr = new("berek2020.txt", Encoding.UTF8);

sr.ReadLine();

while (!sr.EndOfStream)
{
    list.Add(new(sr.ReadLine()!));
}


Console.WriteLine($"3. Feladat: A dolgozók száma:{list.Count}");

double atlag = 0;

for (int i = 0; i < list.Count; i++)
{
    atlag += list[i].ber;
}

Console.WriteLine($"4. Feladat: Bérek átlaga:{atlag / list.Count / 1000:0.0} eFt");

Console.Write("5. Feladat: Kérem a részleg nevét: ");



string reszleg = Console.ReadLine()!;


int maxIndex = 0;
bool isThere = false;
for (int i = 0; i < list.Count; i++)
{
    if (reszleg == list[i].reszleg)
    {
        isThere = true;
        if (list[i].ber > list[maxIndex].ber)
        {
            maxIndex = i;
        }
    }
}

Berek legnagyobb = list[maxIndex];


if (legnagyobb != null && isThere)
{
    Console.WriteLine("6. feladat:");
    Console.WriteLine($"\tNév: {legnagyobb.nev}");
    Console.WriteLine($"\tNem: {legnagyobb.neme}");
    Console.WriteLine($"\tBelépés: {legnagyobb.belepes}");
    Console.WriteLine($"\tBér: {legnagyobb.ber}");
}
else
{
    Console.WriteLine("6. Feladat: A megadott részleg nem létezik");
}




var resze = list.GroupBy(dbok => dbok.reszleg);

Console.WriteLine("7. Feladat: Statisztika");

foreach (var resz in resze)
{
    Console.WriteLine($"\t{(resz.Key)} - {(resz.Count())} fő");
}


