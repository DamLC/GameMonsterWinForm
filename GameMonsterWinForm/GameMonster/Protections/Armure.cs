using System;
using GameMonsterWinForm;

namespace TPjeu.Protections
{
    public class Armure
    {
        private static int potionArmure = 50;
        
        public static decimal durabilité;
        
        public static bool estEntiere
        {
            get {return durabilité > 0;}
            
        }

        public decimal Durabilité
        {
            get => durabilité;
            private set => durabilité = value;
        }
        
        public Armure( decimal durabilité)
        {
            this.Durabilité = durabilité;
            
        }
        public void encaisserDegats(decimal degats, Armure armure)
        {
            if (estEntiere == true)
            {
                durabilité -= degats;
                Niveaux.detailCombat.AppendText("Votre armure encaisse "+degats+ " degats");
                Niveaux.detailCombat.AppendText(Narration.espace());
                Niveaux.detailCombat.AppendText("Il reste "+durabilité + " Pts de durabilité a ton armure\n");

            }
            if(durabilité == 0 || durabilité <0)
            {
                Niveaux.detailCombat.AppendText("BRING!! Votre armure est cassée");
            }
        }
        
        public static decimal soigner()
        {
            Niveaux.detailCombat.AppendText("Vous prenez une potion +50 durabilité d'armure");
            Niveaux.detailCombat.AppendText(Narration.espace());
            return durabilité += potionArmure;
        }
    }
}