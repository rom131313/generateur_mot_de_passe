using System;
using FormationCS;

namespace MyApp
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            // 1 - Demander la longeur du mot de passe (DemanderNombre) int longeur_mot_de_passe = ...
            //int longeurMotDePasse = DemanderNombre("Longueur du mot de passe : ");
            //int longeurMotDePasse = DemanderNombreEntre("Longueur du mot de passe : ", 1, 5);
            int longeurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            // 2 - alphabet "abcd1234" 4 "1d4e"
            // 3 - 3 - comment choisir un caractère aléatoire 

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caracteresSpeciaux = "#&+-";
            string alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;
            string motDePasse = "";
            int longeurAlphabet = alphabet.Length;
            Random rand = new Random();

            // boucler sur longueurMotDePasse
            for (int i = 0; i < longeurMotDePasse; i++)
            {
                int index = rand.Next(0, longeurAlphabet);
                motDePasse += alphabet[index];
                Console.WriteLine(alphabet[index]);
            }
           
            Console.WriteLine(motDePasse);

            // 4 - generer le mot de passe 
            // 5 - Améliorations : choix alphabet
        }
    }
}