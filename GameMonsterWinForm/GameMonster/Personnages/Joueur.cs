using System;
using System.ComponentModel;
using System.Windows.Forms;
using GameMonsterWinForm;
using TPjeu.Accessoire;
using TPjeu.Armes;
using TPjeu.Monstres;
using TPjeu.Protections;

namespace TPjeu.Personnages
{
    public class Joueur
    {
        private De de;
        public static decimal pointVie;

        private Armure corps;
        private Epee arme;
        private string nom;
        private static int potionVie = 50;
        private static int cptPopo = 1;


        public bool estVivant
        {
            get { return pointVie > 0; }

        }

        public decimal PointVie
        {
            get => pointVie;
            private set => pointVie = value;
        }



        public Joueur(string nomDuHero, decimal vieHero, decimal armureDuHero, decimal degatsHero)
        {
            de = new De();
            pointVie = vieHero;
            nom = nomDuHero;
            corps = new Armure(armureDuHero);
            arme = new Epee(degatsHero);
        }


        public int lancerDe(int valeur)
        {
            return De.lancerDe(valeur);
        }

        public void attaque(MonstreFacile monstre)
        {
            int lancerJoueur = lancerDe(26);
            int LancerMonstre = monstre.lancerDe(26);
            if (lancerJoueur >= LancerMonstre)
            {
                Niveaux.combat.AppendText("\n Il vous reste " + PointVie + " PV, ");
                Niveaux.combat.AppendText(Narration.espace());

                Niveaux.combat.AppendText("vous infigez au monstre " + lancerJoueur + " dégats d'épée\n");
                Niveaux.combat.AppendText(Narration.espace());
                monstre.subitDegats();

            }
        }


        public void attaque(Boss boss)
        {

            decimal degats = lancerDe(26) + arme.degatsCAC;

            Niveaux.combat.AppendText("\n Il vous reste " + PointVie + " PV, ");
            Niveaux.combat.AppendText(Narration.espace());
            
            Niveaux.combat.AppendText(DialogueJoueur.effetDegatsJoueur(degats));
            Niveaux.combat.AppendText(Narration.espace());
            Niveaux.combat.AppendText("vous infigez au boss " + degats + " dégats d'épée\n");
            boss.subitDegats(degats);


        }

        public decimal subirDegats(decimal degats)
        {
            if (bouclier(degats) == true)
            {
                Niveaux.combat.AppendText(DialogueJoueur.esquive());
                Niveaux.combat.AppendText(Narration.espace());

                return pointVie;
            }
            else
            {
                return pointVie -= degats;
            }
        }

        public decimal subitDegats(decimal degats)
        {
            if (bouclier(degats) == true)
            {
                Niveaux.combat.AppendText(DialogueJoueur.esquive());
                Niveaux.combat.AppendText(Narration.espace());

                return pointVie;
            }

            if (Armure.estEntiere == true)
            {
                corps.encaisserDegats(degats, corps);
                return pointVie;
            }
            else
            {
                Niveaux.combat.AppendText("le monstre vous inflige " + degats + " dégats \n");
                return pointVie -= degats;
            }
        }



        public bool bouclier(decimal degats)
        {
            int score = lancerDe(6);

            if (score <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string levelUp(int xp)
        {
            if (xp < 50)
            {
                return ("Pas de chance tu reste lvl 1");
            }

            if (xp == 50)
            {
                return ("t'appelle ça combattre lvl 2 ");
            }

            if (xp > 50 && xp < 100)
            {
                return (" Peut mieux faire  lvl 3");
            }

            if (xp > 100 && xp < 150)
            {
                return ("lvl 4 Potentiel vraiment tres caché alors! ");
            }

            if (xp > 150 && xp < 200)
            {
                return ("C'est presque pas mal lvl 5");
            }

            if (xp > 200 && xp < 250)
            {
                return (" En progrés lvl 6");
            }

            if (xp > 250 && xp < 300)
            {
                return (" C'est pas grandiose tous ça  lvl 7");
            }

            if (xp > 300 && xp < 350)
            {
                return (" Mouais lvl 8");
            }

            if (xp > 350 && xp < 400)
            {
                return (" Au moins tu sais te servir d'un épée  lvl 9");
            }

            if (xp > 400 && xp < 450)
            {
                return (" A du potentiel lvl 10");
            }

            if (xp > 450 && xp < 500)
            {
                return ("  lvl 11");
            }

            if (xp > 500 && xp < 550)
            {
                return ("  lvl 12");
            }

            if (xp > 550 && xp < 600)
            {
                return (" lvl 13");
            }

            if (xp > 600 && xp < 650)
            {
                return ("  lvl 14");
            }

            if (xp > 650 && xp < 700)
            {
                return ("  lvl 15");
            }

            if (xp > 700 && xp < 750)
            {
                return ("  lvl 16");
            }

            if (xp > 750 && xp < 800)
            {
                return ("  lvl 17");
            }

            if (xp > 800 && xp < 850)
            {
                return ("  lvl 18");
            }

            if (xp > 850 && xp < 900)
            {
                return ("  lvl 19");
            }

            if (xp > 900 && xp < 950)
            {
                return ("  lvl 20");
            }

            if (xp > 950 && xp < 1000)
            {
                return ("  lvl 21");
            }

            if (xp > 1000)
            {
                return ("GG ! lvl 22");
            }

            return "";
        }

        public static decimal soigner()
        {
            

            if (cptPopo == 1 && ((Form1._niveau1 == true && Form1.heroCree == true)|| (Form1._niveauF == true && Form1.heroCree == true && Form1.bossCree == true)))
            {
                Niveaux.combat.AppendText("Vous prenez une potion +50 PV");
                Niveaux.combat.AppendText(Narration.espace());
                cptPopo--;
                return pointVie += potionVie;
            }

            if (cptPopo == 1 && (Form1._niveau1 == false || Form1._niveauF == false))
            {
                MessageBox.Show("Vous devez être en partie pour prendre une potion");
            }
            else
            {
                MessageBox.Show("Vous n'avez plus de potion de soins");
            }

            return pointVie;
        }
    }
}