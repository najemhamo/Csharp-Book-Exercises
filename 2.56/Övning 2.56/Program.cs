using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_2._56
{
    class Program
    {
        static void Main(string[] args)
        {
            Samling<int> s = new Mängd<int>();
            Console.WriteLine("En lista son innehåller siffror (int) skapas. Här är komandon du kan använda");
            Console.WriteLine("L :---------- Lägg till en siffra i listan");
            Console.WriteLine("T :---------- Ta bort en siffra från listan");
            Console.WriteLine("I :---------- Visar siffrans position i listan(index)");
            Console.WriteLine("R :---------- Skriv siffrans index och få siffran");
            Console.WriteLine("A :---------- Lägg till flera siffror i listan");
            Console.WriteLine("H :---------- Kolla om siffran finns i listan");
            Console.WriteLine("V :---------- Visa listan");
            Console.WriteLine();

       
            while (true)
            {
                string komando = Console.ReadLine();

                if (komando.Equals("L"))
                {
                   // LäggTill
                    Console.WriteLine("Skriv siffran här:");
                    try
                    {
                        s.LäggTill(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Siffran lades i listan :)");
                    }
                    catch (FinnsException f)
                    {
                        Console.WriteLine(f.Message);
                    }
                    
                }
                else if (komando.Equals("V"))
                {
                    //ElementFrån
                    for (int i = 0; i < s.Antal(); i++)
                    {
                        Console.Write(s.ElementFrån(i) + " ");
                    }
                }
                else if (komando.Equals("T"))
                {
                    //TaBort
                    Console.WriteLine("Skriv indexet här:");
                    s.TaBort(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Siffran har tagits bort :(");
                }
                else if (komando.Equals("I"))
                {
                    //Sök
                    Console.WriteLine("Skriv siffran här:");
                    int index = s.Sök(int.Parse(Console.ReadLine()));
                    Console.WriteLine(index);
                }
                else if (komando.Equals("R"))
                {
                    //ElementFrån
                    Console.WriteLine("Skriv indexet här:");
                    int siffra = s.ElementFrån(int.Parse(Console.ReadLine()));
                    Console.WriteLine(siffra);
                }
                else if (komando.Equals("A"))
                {
                    Console.WriteLine("Skriv siffrorna som detta exemplet 1 2 3 4 5 asså med mellan slag i mellan");

                    //LäggTill
                    string[] number = Console.ReadLine().Split(' ');
                    Samling<int> nyLista = new Samling<int>();

                    for (int i = 0; i < number.Length; i++)
                    {
                        nyLista.LäggTill(int.Parse(number[i]));
                    }
                    s.LäggTill(nyLista);
                    Console.WriteLine("Siffrorna lades i listan :)");
                }
                else if (komando.Equals("H"))
                {

                  
                    Console.WriteLine("Skriv siffran här:");
                    bool finns = s.Har(int.Parse(Console.ReadLine()));
                    if (finns)
                    {
                        Console.WriteLine("Siffran finns i listan :)");
                    }else
                    {
                        Console.WriteLine("Siffran finns inte i listan :(");
                    }
                }
                }








            Console.ReadKey();
        }
    }
}
