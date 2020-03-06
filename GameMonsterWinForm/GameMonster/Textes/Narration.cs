using System;

namespace TPjeu
{
    public class Narration
    {
        public static string debut()
        {
            return("Aprés avoir écouter les histoires d'aventure de tonton Norbert,\n " +
                   "vous décidez de partir a l'aventure a votre tour ...\n ");
        }
        public static string arrivee()
        {
            
            return("Aprés avoir marcher 4km vous apperçever un donjon au bout du chemin. " +
                   " Et comme un gros noob, vous décidez d'y aller TOUS seul avec un équipements\n... des plus déplorable.\n ");
            
            
        }public static string niveau()
        {
            return("Par chance vous arrivez a survivre jusqu au 3ème étages.\n " +
                   "Malheureusement ce niveau est un cimetière et dans votre malheur " +
                   "tout au fond de la salle se trouve  un nécromancien." +
                   "Il s'apprète a ramenner ces potes monstre a la vie .");
        }
        public static string combat()
        {
            return("Vous saississez  votre épée semi rouillé et vous préparez au pire .\n ");
        }
        public static string fin()
        {
            return("\nTu fera mieux la prochaine fois." +
                   "Sponsorisé par 'MERCUROCHROME' XD\n ");
        }
        
        public static string deuxiemeChance()
        {
            return("Grace a l'amulette du couard de tonton Norbert vous ressussitez au 1er étage  \n" );
        }

        public static string boss()
        {
            return("Un boss térrifiant vous fait face...\n");
        }
        public static string espace()
        {
            return("\n");
        }
        
        public static string fin2()
        {
            return("Après un dur combat notre  hero rentre chez lui, pace que  ..." +
                   "c'est l'heure de la soupe faut pas déconé!\n ");
        }
        public static string fin3()
        {
            return("n'ayant  pas réussi a tuer le boss" +
                   " Notre hero s'envole pour le paradis des noobs\n");
        }


    }
    
}