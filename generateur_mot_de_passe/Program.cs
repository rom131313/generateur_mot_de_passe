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
            // 4 - generer le mot de passe 
            // 5 - Améliorations : choix alphabet
        }
    }
}