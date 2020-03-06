using GameMonsterWinForm;
using TPjeu.Monstres;
using TPjeu.Personnages;

namespace TPjeu.Monstres
{
    public class MonstreDifficile : MonstreFacile
    {
        private int degatsMagique = 5;
        
        public void sortMagique(Joueur joueur)
        {
            int lancerJoueur = joueur.lancerDe(26);
            if ( lancerJoueur< 6)
            {
                Niveaux.detailCombat.AppendText("le monstre difficile vous inflige " + lancerJoueur *degatsMagique + " dégats \n");
                Niveaux.detailCombat.AppendText(Narration.espace());
                 joueur.subirDegats(lancerJoueur * degatsMagique);
                 Niveaux.detailCombat.AppendText("\n Il vous reste " + joueur.PointVie + " PV, ");
            }                            
        }
    }
   
}