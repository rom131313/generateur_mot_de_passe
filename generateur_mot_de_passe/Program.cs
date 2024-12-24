using System;
using System.Runtime.Intrinsics.X86;
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
            //int longeurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            // Vous voulez un mot de passe avec : 
            // 1 - Uniquement des caractères en minuscule
            // 2 - Des caractères minuscues et majuscules
            // 3 - Des caractères et des chiffres 
            // 4 - Caractères, chiffres et caractères spériaux


            // Poser la question
            // en fonction du choix alphabet

            // 2 - alphabet "abcd1234" 4 "1d4e"
            // 3 - 3 - comment choisir un caractère aléatoire 

            //string minuscules = "abcdefghijklmnopqrstuvwxyz";
            //string majuscules = minuscules.ToUpper();
            //string chiffres = "0123456789";
            //string caracteresSpeciaux = "#&+-";
            //string alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;

            string question = "Vous voulez un mot de passe avec : \n1 - Uniquement des caractères en minuscule \n2 - Des caractères minuscues et majuscules \n3 - Des caractères et des chiffres \n4 - Caractères, chiffres et caractères spériaux";
            string alphabet = outils.DemanderAlphabet(question);
            Console.WriteLine(alphabet);
            string motDePasse = "";
            int longeurAlphabet = alphabet.Length;
            Random rand = new Random();

            //// boucler sur longueurMotDePasse
            //for (int i = 0; i < longeurMotDePasse; i++)
            //{
            //    int index = rand.Next(0, longeurAlphabet);
            //    motDePasse += alphabet[index];
            //    Console.WriteLine(alphabet[index]);
            //}
           
            //Console.WriteLine(motDePasse);

            // 4 - generer le mot de passe 
            // 5 - Améliorations : choix alphabet
        }
    }
}