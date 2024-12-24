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
        enum e_Alphabet
        {
            MINUSCULES = 1,
            MAJUSCULES = 2,
            CHIFFRES = 3,
            SPECIAUX = 4
        }
        public static string DemanderAlphabet(string question)
        {
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-";
            string alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;

            int choix = DemanderNombreEntre(question, 1, 4);
            e_Alphabet a = (e_Alphabet)choix;
            switch (a)
            {
                case e_Alphabet.MINUSCULES:
                    alphabet = minuscules;
                    break;
                case e_Alphabet.MAJUSCULES:
                    alphabet = minuscules + majuscules;
                    break;
                case e_Alphabet.CHIFFRES:
                    alphabet = minuscules + majuscules + chiffres;
                    break;
                case e_Alphabet.SPECIAUX:
                    alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
                    break;
                default:
                    Console.WriteLine("ERREUR : Veuillez choisir un choix entre 1 et 4");
                    break;
            }
            return alphabet;
        }
    }
}
