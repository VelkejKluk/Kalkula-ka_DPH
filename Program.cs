using System;
//Chcete přidat / odebrat DPH?
Console.WriteLine("Chcete přidat nebo odebrat DPH? [P/O]");
string volba = Console.ReadLine().ToLower();

if (volba != "p"&& volba != "o")
{
    Console.WriteLine("Chybně zadaný formát...");
    
}
//Zeptej se uživatele na cenu 
Console.WriteLine("Jaká je cena produktu?");
int cena = Convert.ToInt32(Console.ReadLine());
    
//pdomínka, když uživatel zadá přidat nebo odebrat
if (volba == "p")
{
    Console.WriteLine($"Když je DPH 21 %, tak vaše cena je: {cena/100*121}");
}
else if(volba == "o")
{
    Console.WriteLine($"Když je DPH 21 %, tak vaše cena je: {cena / 100 * 79}");
}