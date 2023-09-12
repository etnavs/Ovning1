/*
 * Jag har mycket att lära. Jag vet ingenting om
 * klasser, attribut och metoder. Inte heller kan
 * jag skriva ett program som inte behöver veta 
 * hur många anställda företaget har. Varför det
 * strular med lönen vet jag inte heller. Jaja,
 * det löser sig väl...
 * 
*/


Console.WriteLine("Hur många anställda?");

string Aanst = Console.ReadLine();
int anst = Convert.ToInt32(Aanst);

string[] anstnr = new string[anst];
string[] lonA = new string[anst];

for (int i = 0; i < anst; i++)
{
    Console.WriteLine("Vad heter anställd nr " + (i + 1) +"?");
    anstnr[i] = Console.ReadLine();

    Console.WriteLine("Ange lönen för " + anstnr[i]);
    lonA[i] = Console.ReadLine();

    // Varför gillar den inte lonB[i]?
    //int lonB[i] = Convert.ToInt32(lonA[i]);
}

Console.WriteLine(" ");
Console.WriteLine("De anställda är:");
for (int i = 0; i < anst; i++)
{
    Console.WriteLine(anstnr[i]);
}
