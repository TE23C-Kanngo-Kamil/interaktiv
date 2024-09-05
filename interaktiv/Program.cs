Console.WriteLine("Användarnamn:");
string name = Console.ReadLine().ToLower();

if (name == "kamil" || name == "ares" || name == "edward")
{
    Console.WriteLine("Välkommen!");
}
else
{
    Console.WriteLine("Stick härifrån!");
}

Console.ReadLine();

    string choice = "";

Console.WriteLine("Du står vid en mörk skog. Det är kväll, och dimman ligger tjock över marken. Framför dig finns två stigar.");
Console.WriteLine("Den vänstra stigen leder djupt in i skogen där ett svagt ljus fladdrar långt bort.");
Console.WriteLine("Den högra stigen leder mot en gammal stenbro över en tyst flod.");
Console.WriteLine("Vilken väg väljer du? Vänster eller höger?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
    Console.WriteLine("Du går mot stenbron, och plötsligt hör du ett knakande ljud under dina fötter.");
    Console.WriteLine("Du stannar, men för sent!");
    Console.WriteLine("Bron, som tydligen varit ur bruk i flera år, ger vika, och du faller rakt ner i floden.");
    Console.WriteLine("Som tur är vattnet väldigt grunt, men oturligt nog landar du på en vresig bäverfamiljs timmerhydda.");
    Console.WriteLine("De är inte glada över ditt intrång.");
    Console.WriteLine("Innan du ens hinner resa dig upp, blir du attackerad av en svärm arga bävrar, som försvarar sitt hem med otrolig intensitet.");
    Console.WriteLine("Deras små men sylvassa tänder hugger som en hord fickknivar, och du inser att du är på väg att möta ditt slut... mot en grupp bävrar.");
}
else if (choice == "vänster")
{
    Console.WriteLine("Du går längs den smala stigen, och träden växer tätare runt dig.");
    Console.WriteLine("Det fladdrande ljuset blir starkare, och snart ser du en gammal stuga inbäddad i en glänta.");
    Console.WriteLine("Röken från skorstenen stiger långsamt uppåt, och du hör ett svagt mumlande inifrån.");
    Console.WriteLine("Gå in i stugan eller undersök runt stugan?");
}
  choice = Console.ReadLine();
  choice = choice.ToLower();

if (choice == "undersök runt stugan")
{
    Console.WriteLine("Du går tyst runt stugan men du råkar ta ett fel steg och faller rakt ner för en lång trappa in i mörkret.");
    Console.WriteLine("I källaren hittar du en magisk bok på ett gammalt träbord.");
    Console.WriteLine("Du tar upp boken och bläddrar i den.");
    Console.WriteLine("Genom att läsa de mystiska texterna får du plötsligt en kraft inom dig, du har nu magiska förmågor!");
}
else if (choice == "gå in i stugan")
{
    Console.WriteLine("När du öppnar dörren knarrar den högt.");
    Console.WriteLine("En gammal kvinna sitter vid eldstaden och tittar upp på dig med ett snett leende.");
    Console.WriteLine("\"Jag har väntat på dig\", säger hon med en raspig röst.");
    Console.WriteLine("Hon erbjuder dig en skål soppa.");
    Console.WriteLine("Du känner att något inte stämmer och även fast du tackar nej och förklarar att du inte är hungrig insisterar kvinnan och ger dig en skål soppa.");
    Console.WriteLine("När du dricker soppan känner du genast hur en värme sprider sig i din kropp.");
    Console.WriteLine("Men värmen övergår snabbt till något mer intensivt.");
    Console.WriteLine("Dina armar förvandlas långsamt till trä, och du inser att du förvandlas till ett träd!");
    Console.WriteLine("Kvinnan ler brett.");
    Console.WriteLine("Du blir ett med skogen för alltid.");
}
else
{
    Console.WriteLine("Din klant! Du skrev inget jag kunde förstå, så nu dör du automatiskt.");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();