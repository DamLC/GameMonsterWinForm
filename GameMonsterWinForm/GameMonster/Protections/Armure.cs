using System;
using GameMonsterWinForm;

namespace TPjeu.Protections
{
    public class Armure
    {
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
                Form1.combat.AppendText("Votre armure encaisse "+degats+ " degats");
                Form1.combat.AppendText("Il reste "+durabilité + " Pts de durabilité a ton armure\n");

            }
            if(durabilité == 0 || durabilité <0)
            {
                Form1.combat.AppendText("BRING!! Votre armure est cassée");
            }
        }
    }
}