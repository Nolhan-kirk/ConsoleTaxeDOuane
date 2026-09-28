using System.ComponentModel.Design;

namespace ConsoleTaxeDOuane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal arme;
            string provenance;
            const decimal TaxeRoyale = 0.20m;
            const decimal TaxeMiniere = 0.10m;
            const decimal TaxeReduite = 0.055m;
            const decimal TaxeBeni = 0.021m;


            Console.WriteLine("Saisir le prix de l'arme");
            arme = decimal.Parse (Console.ReadLine());

            Console.WriteLine("Saisir provenance de l'arme (Capitale , Nains , Contrebande , Temple");
            provenance = Console.ReadLine ();

            if (provenance == "Capitale")
                arme = (arme + arme * TaxeRoyale);
            else if (provenance == "Nains")
                arme = (arme + arme * TaxeMiniere);
            else if (provenance == "Contrebande")
                arme = (arme + arme * TaxeReduite);
            else if (provenance == "Temple")
                arme = (arme + arme * TaxeBeni);


            Console.WriteLine($"le prix de votre arme est de {arme}");

        }
    }
}
