using GameMonsterWinForm;
using TPjeu.Accessoire;
using TPjeu.Personnages;

namespace TPjeu.Monstres
{
    public class MonstreFacile
    {
        private De de;
        public bool estVivant { get; private set; }

        public MonstreFacile()
        {
            de= new De();
            this.estVivant = true;
        }

        public int lancerDe(int valeur )
        {
            return De.lancerDe(valeur);
        }
        
        public void attaque(Joueur joueur)
        {
            int lancerJoueur = joueur.lancerDe(26);
            int  degats =   lancerDe(26);
            if (lancerJoueur < degats)
            {
                Niveaux.combat.AppendText(Narration.espace());
                joueur.subitDegats(degats);
            }
        }

        public void  subitDegats()
        {
            estVivant = false;
            Niveaux.combat.AppendText("vous avez one shoot le monstre\n");
            Niveaux.combat.AppendText(Narration.espace());
        }
    }
}