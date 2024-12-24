using System;

namespace MyApp
{
    internal class Program
    {
        static int DemanderNombrePositifNonNul(string question)
        {
            // > 0
            //return DemanderNombreEntre(question, 0, int.MaxValue);
            int nombre = DemanderNombre(question);
            while (nombre <= 0) {
                Console.WriteLine("ERREUR : Le nombre doit être supérieur à 0");
                nombre = DemanderNombre(question);
            }
            return nombre;
        }

        static int DemanderNombreEntre(string question, int min, int max)
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
        static int DemanderNombre(string question)
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

        static void Main(string[] args)
        {
            // 1 - Demander la longeur du mot de passe (DemanderNombre) int longeur_mot_de_passe = ...
            //int longeurMotDePasse = DemanderNombre("Longueur du mot de passe : ");
            //int longeurMotDePasse = DemanderNombreEntre("Longueur du mot de passe : ", 1, 5);
            int longeurMotDePasse = DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            // 2 - alphabet "abcd1234" 4 "1d4e"
            // 3 - 3 - comment choisir un caractère aléatoire 
            // 4 - generer le mot de passe 
            // 5 - Améliorations : choix alphabet
        }
    }
}