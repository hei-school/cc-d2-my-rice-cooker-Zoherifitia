using System;

class Program
{
    static bool powerOne = false;
    static bool keepWarm = false; // quand cook est fini avec succès
    // en g
    const int maxWeight = 500;
    static int weight = 0;
    static int start = 0;

    static void Cook()
    {
        if (weight == 0)
        {
            Console.Write("Le poids du riz : ");
            weight = int.Parse(Console.ReadLine());

            if (weight > maxWeight)
            {
                weight = 0;
                Console.WriteLine("Y a beaucoup trop de riz");
            }
            else
            {
                Console.Write("Pour ajouter de l'eau dans le rice cooker, cliquer sur enter");
                Console.ReadLine();
                Console.Write("Si vous voulez faire cuire tout de suite, cliquer sur le nombre 0 sinon veuillez indiquer dans combien de minute vous voulez commencer la cuisson : ");
                start = int.Parse(Console.ReadLine());

                if (start == 0)
                {
                    powerOne = true;
                    Console.WriteLine("Cuisson");
                }
                else
                {
                    Console.WriteLine("La cuisson commencera dans " + start + " minutes");
                }

                keepWarm = true;
                Console.WriteLine("Maintien au chaud ");
            }
        }
        else
        {
            Console.WriteLine("Vous ne pouvez pas en ajouter");
        }
    }

    static void Prediction()
    {
        if (weight <= 500 && weight > 300)
        {
            Console.WriteLine("Votre cuisson sera finie dans " + (45 + start) + "min");
        }
        else if (weight <= 300 && weight > 100)
        {
            Console.WriteLine("Votre cuisson sera finie dans "+(35+start)+"min");
        }
        else if (weight <= 100 && weight>0)
        {
            Console.WriteLine("Votre cuisson sera finie dans "+(20+start)+"min");
        }
        else
        {
            Console.WriteLine("Y a meme pas de riz dans le rice cooker");
        }
    }

    static void Main()
    {
        int option;

        do
        {
            Console.Write("Entrez votre choix : ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Cook();
                    break;
                case 2:
                    Prediction();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }

            /*Console.Write("Entrer un autre choix : ");
            option = int.Parse(Console.ReadLine());*/

        } while (option != 3);
    }
}
