// string score = "0";
// int score = 0;

// score += 1;

// if (score > 0)
{
    
    {
        int poäng = 0;

        // Fråga1
        Console.WriteLine("Vilket år blev Sverige medlem i Europeiska unionen (EU)?");
        Console.WriteLine("a) 1992"); Console.WriteLine("b) 1995"); Console.WriteLine("c) 2001");
        
        string svar1 = Console.ReadLine();

        if (svar1 == "b")
        {
            Console.WriteLine("Rätt");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är b");
        }
        // Fråga2  
        Console.WriteLine("\nVad heter Sveriges högsta berg?");
        Console.WriteLine("a) Kebnekaise"); Console.WriteLine("b) Åreskutan"); Console.WriteLine("c) Helagsfjället");
       
        string svar2 = Console.ReadLine();
         if (svar2 == "a")
        {
            Console.WriteLine("Rätt");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är b");
        }

        // Fråga3
        Console.WriteLine("\nVilken svensk stad är känd som “Lilla London”?");
        Console.WriteLine("a) Malmö"); Console.WriteLine("b) Göteborg"); Console.WriteLine("c) Uppsala");
        
        string svar3 = Console.ReadLine();

        if (svar3 == "b")
        {
            Console.WriteLine("Rätt");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel! Rätt svar är b");
        }

        // resultat
        Console.WriteLine($"\nDu fick {poäng} av 3 ");

        // poäng
        if (poäng == 3)
        {
            Console.WriteLine("Du fick alla rätt");
        }
        else if (poäng == 2)
        {
            Console.WriteLine("Du fick 2 av 3 rätt");
        }
        else if (poäng == 1)
        {
            Console.WriteLine("dåligt Du fick 1 av 3 rätt");
        }
        else
        {
            Console.WriteLine("Bättre lycka nästa gång. Du fick inga rätt");
        }
    }
}
Console.ReadLine();