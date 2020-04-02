using System;
using System.Windows.Forms;
using GameMonsterWinForm;

namespace TPjeu.Protections
{
    public class Armure
    {
        private static int potionArmure = 50;
        private static int cptPopo = 1;
        
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
                Niveaux.combat.AppendText("Votre armure encaisse "+degats+ " degats");
                Niveaux.combat.AppendText(Narration.espace());
                Niveaux.combat.AppendText("Il reste "+durabilité + " Pts de durabilité a ton armure\n");

            }
            if(durabilité == 0 || durabilité <0)
            {
                Niveaux.combat.AppendText("BRING!! Votre armure est cassée");
            }
        }
        
        public static decimal soigner()
        {
            if (cptPopo == 1 && ((Form1._niveau1 == true && Form1.heroCree == true)|| (Form1._niveauF == true && Form1.heroCree == true && Form1.bossCree == true)))
            {
                Niveaux.combat.AppendText("Vous prenez une potion +50 durabilité d'armure");
                Niveaux.combat.AppendText(Narration.espace());
                cptPopo--;
                return durabilité += potionArmure;
            }
            if (cptPopo == 1 && (Form1._niveau1 == false || Form1._niveauF == false))
            {
                MessageBox.Show("Vous devez être en partie pour prendre une potion");
            }
            else
            {
                MessageBox.Show("Vous n'avez plus de potion ");
            }

            return durabilité;
        }
    }
}