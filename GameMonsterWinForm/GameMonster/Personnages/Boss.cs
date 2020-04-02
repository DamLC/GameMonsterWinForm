using System;
using GameMonsterWinForm;
using TPjeu.Accessoire;
using TPjeu.Armes;

namespace TPjeu.Personnages
{
    public class Boss
    {
        private De de;
        public  decimal pointVie;
        private EpeeBoss epee;
        private string nom;

        public bool estVivant
        {
            get {return pointVie > 0;}
            
        }

        public decimal PointVie
        {
            get => pointVie;
            private set => pointVie = value;
        }

     
        public Boss( string nomDuBoss,decimal vieBoss, decimal degatsBoss)
        {
            de = new De();
            pointVie = vieBoss;
            nom = nomDuBoss;
            epee = new EpeeBoss(degatsBoss); 
        }

        public int lancerDe( int valeur)
        {
            return De.lancerDe(valeur);
        }

        public void attaque(Joueur joueur)
        {

            decimal degats = lancerDe(26);

            if (pointVie <100)
            {
                degats = lancerDe(26) + epee.frappe;
            }
            
            Niveaux.combat.AppendText(" Il  reste "+ pointVie + " PV au boss, ");
            Niveaux.combat.AppendText(Narration.espace());
            Niveaux.combat.AppendText( DialogueBoss.effetDegatsBoss(degats));
            Niveaux.combat.AppendText(Narration.espace());
            Niveaux.combat.AppendText(" le boss vous infige "+degats+" dégats\n");
            joueur.subitDegats(degats);
            
           
            
        }

        public decimal subitDegats(decimal degats)
        {
            
            return pointVie -= degats;
            
        }

       
    }
}