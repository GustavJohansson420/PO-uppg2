class Program
{
    static void Main()
    {
        Console.WriteLine("Skriv ett nummer");
        int kryptnummer = Convert.ToInt32(Console.ReadLine());
        if (kryptnummer <= 0)
        {
            Console.WriteLine("Fel! du måste skrive ett positivt heltal som inte är 0");
        }
        else if (kryptnummer >= 1 && kryptnummer <= 10)
        {
            Console.WriteLine("Det finns 1 möjlig bokstavskombination.");
        }
        else if (kryptnummer >= 11 && kryptnummer <=29 && kryptnummer != 20)
        {
            Console.WriteLine("Det finns 2 möjliga bokstavskombinationer.");
        }
        else if (kryptnummer == 20)
        {
            Console.WriteLine("Det finns 1 möjlig bokstavskombination.");
        }
        else if (kryptnummer >= 30 && kryptnummer <=99)
        {
            Console.WriteLine("Det finns 1 möjlig bokstavskombination.");
        }
        else 
        {
            Console.WriteLine("Siffran är för stor för min hjärna lol. Prova ett tal mellan 1 och 99");
        }
    }
}

