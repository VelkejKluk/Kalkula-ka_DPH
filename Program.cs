using System;

while (true) 
{
    //Chcete přidat / odebrat DPH?
    Console.WriteLine("Chcete přidat nebo odebrat DPH? [P/O]");
    string volba = Console.ReadLine().ToLower();

    if (volba != "p"&& volba != "o")
    {
        Console.WriteLine("Chybně zadaný formát...");
    }
    else
    {
        Console.Write("Chcete zadat jen jednu hodnotu, nebo více? [a/n]");
        string an  = Console.ReadLine();

        if (an != "a")
        {
            VolbaVice();
        }
        else if(an != "n")
        {
            //Zeptej se uživatele na cenu 
            Console.Write("Jaká je cena produktu? ");
            int cena = Convert.ToInt32(Console.ReadLine());

            //pdomínka, když uživatel zadá přidat nebo odebrat
            if (volba == "p")
            {
                Console.WriteLine($"Když je DPH 21 %, tak vaše cena je: {cena / 100 * 121} Kč");
                Console.ReadKey(); Console.Clear();
            }
            else if (volba == "o")
            {
                Console.WriteLine($"Když je DPH 21 %, tak vaše cena je: {cena / 100 * 79} Kč");
                Console.ReadKey(); Console.Clear();
            }
        }
        else
        {
            Console.WriteLine("chyba more");
        }
    }
}


static void VolbaVice()
{
    Console.Write("Kolik hodnot chcete zadat? ");

    int pocet = Convert.ToInt32(Console.ReadLine());

    int[] hodnoty = new int[pocet - 1];





}
