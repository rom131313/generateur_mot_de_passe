using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FormationCS. outils.DemanderNombrePositifNonNul

namespace FormationCS
{
    static class outils
    {
    
        public static int DemanderNombrePositifNonNul(string question)
        {
            // > 0
            //return DemanderNombreEntre(question, 0, int.MaxValue);
            int nombre = DemanderNombre(question);
            while (nombre <= 0)
            {
                Console.WriteLine("ERREUR : Le nombre doit être supérieur à 0");
                nombre = DemanderNombre(question);
            }
            return nombre;
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            // DemanderNombre(question)
            // si le nombre est bien entre min et max -> ERREUR / boucler ....<
            int nombre = DemanderNombre(question);
            while (nombre < min || nombre > max)
            {
                Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);
                nombre = DemanderNombre(question);
            }
            return nombre;
        }
        public static int DemanderNombre(string question)
        {
            // poser la question
            // récupérer la réponse
            // convertir 
            // gérer l'erreur de conversion
            // boucler tant qu'on a pas reçu une réponse valide (qui contient que des chiffres)
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
        }
    }
}
