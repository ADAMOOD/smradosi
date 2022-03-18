// See hConsole.WriteLine("zadej kolik máš smraďochů:");
int pocetSmradochu = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= pocetSmradochu; i++)
{
    Console.WriteLine($"zadej smraďocha číslo {i} ");
    string smradoch = Console.ReadLine();
    smradosi(smradoch);

}
static void smradosi(string smradoch)
{
    double prumer = 0;
    int suma = 0;
    for (int i = 0; i < smradoch.Length; i++)
    {
        suma += smradoch[i];

    }
    prumer = (Math.Round((double)suma / smradoch.Length));
    Console.Write(smradoch);
    
    if (prumer % 7 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" smrdí jako cibuláč");
    }
    else if (prumer % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" smrdí jako koňská řiť");
    }
    else if (prumer % 3 == 0)
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Beep();
        Console.WriteLine(" smrdí jako bolava noha bezdomovce");

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" nesmrdí nijak");
    }
    Console.ForegroundColor = ConsoleColor.Gray;
}