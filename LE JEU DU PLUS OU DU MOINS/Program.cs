using System;

namespace LE_JEU_DU_PLUS_OU_DU_MOINS
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreATrouver = new Random().Next(1, 100);
            int essais = 0;
            bool faux = false;
            Console.WriteLine("Saisissez un nombre entre 0 et 100.");
            while (!faux)
            {
                string saisie = Console.ReadLine();
                int numerique;
                if (int.TryParse(saisie, out numerique))
                {
                    if (numerique<0 || numerique>100)
                    {
                        Console.WriteLine("La valeur saisie n'est pas entre 0 et 100");
                        essais++;
                    }
                    else
                    {
                        if (numerique<nombreATrouver)
                        {
                            Console.WriteLine("C'est plus...");
                            essais++;
                        }
                        else
                        {
                            Console.WriteLine("C'est moins...");
                            essais++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La valeur saisie n'est pas entre 0 et 100");
                    essais++;
                }
                if (numerique == nombreATrouver)
                {
                    faux = true;
                }
            }
            Console.WriteLine("Vous avez trouvé " + nombreATrouver);
        }
    }
}