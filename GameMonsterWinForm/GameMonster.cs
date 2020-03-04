using System;
using System.Windows.Forms;
using TPjeu;
using TPjeu.Personnages;

namespace GameMonsterWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Attribut Hero

        private Joueur hero;
        private bool heroCree = false;
        private string nomDuHero;
        private static decimal vieHero;
        private decimal armureDuHero;
        private decimal degatsHero;

        #endregion


        #region Attribut Boss

        private Boss _boss;
        private bool bossCree = false;
        private string nomDuBoss;
        private decimal vieBoss;
        private decimal degatsBoss;


        #endregion

        #region Function Hero

        private void nomHero_TextChanged(object sender, EventArgs e)
        {
            nomDuHero = nomHero.Text;                }
        
        private void heroPV_ValueChanged(object sender, EventArgs e)
        {
            vieHero = heroPV.Value;
        }
        
        private void armureHero_ValueChanged(object sender, EventArgs e)
        {
            armureDuHero = armureHero.Value;
        }
        
        private void degatsEpeeHero_ValueChanged(object sender, EventArgs e)
        {
            degatsHero = degatsEpeeHero.Value;
        }

        #endregion

        #region Function Boss

        private void nomBoss_TextChanged(object sender, EventArgs e)
        {
            nomDuBoss = nomBoss.Text;
        }
        
        private void bossPV_ValueChanged(object sender, EventArgs e)
        {
            vieBoss = bossPV.Value;
        }
        
        private void degatsEpeeBoss_ValueChanged(object sender, EventArgs e)
        {
            degatsBoss = degatsEpeeBoss.Value;
        }

        #endregion
        
        #region Creation de personnages

        private void creeHero_Click(object sender, EventArgs e)
        {
            if (heroCree != true)
            {
                if (nomHero.Text == "" || heroPV.Value == 0 || armureHero.Value == 0 || degatsEpeeHero.Value == 0)
                {
                    MessageBox.Show("Veulliez remplir les champs");
                    
                   if (nomHero.Text == "")
                   {
                       MessageBox.Show("veulliez nommer votre hero!\n" +
                                    "Un hero sans nom ne peut pas être connu.");
                       
                   }
                }
                else
                {

                    hero = new Joueur(nomDuHero, vieHero, armureDuHero, degatsHero);
                    combat.AppendText("Notre hero " +
                                      nomDuHero + " a été créer! \n " +
                                      vieHero + " PV\n " +
                                      armureDuHero + " durabilité d'armure\n " +
                                      degatsHero + " dégats d'épée \n");
                    heroCree = true;

                }
            }
            else
            {
                MessageBox.Show("Un hero a deja été créer!");
            }
        }

        private void creeBoss_Click(object sender, EventArgs e)
        {
            if (bossCree != true)
            {
                if (nomBoss.Text == "" || bossPV.Value == 0 || degatsEpeeBoss.Value == 0)
                {
                    MessageBox.Show("Veulliez remplir les champs");

                }
                else
                {

                    _boss = new Boss(nomDuBoss, vieBoss, degatsBoss);
                    combat.AppendText("Le boss " +
                                      nomDuBoss + " a été créer! \n " +
                                      vieBoss + " PV\n " +
                                      degatsBoss + " dégats d'épée \n");
                    bossCree = true;

                }
            }

            else
            {
                MessageBox.Show("Un boss a deja été créer!");
            }
        }

        #endregion

        #region Attaque

        private void buttonDe_Click(object sender, EventArgs e)
        {
            try
            {
                while (hero.estVivant == true && _boss.estVivant == true)
                {
                    hero.attaque(_boss);
                    combat.AppendText(Narration.espace());
                
                    if (_boss.estVivant)
                    {
                        _boss.attaque(hero);
                        combat.AppendText(Narration.espace());
                                    
                    }
                    
                }
                            
                if( _boss.estVivant)
                {
                    MessageBox.Show(DialogueJoueur.deuxiemeMort()) ;
                    MessageBox.Show(DialogueBoss.tueJoueur());
                    MessageBox.Show(Narration.fin3());
                    MessageBox.Show(Narration.fin());
                }
                else
                {
                    MessageBox.Show(DialogueJoueur.tueBoss());
                    MessageBox.Show(Narration.fin2());
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("Pour attaquer il faut un hero et un boss");
            }
        
        
        }

        #endregion

        #region Quitter

        private void end_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        #endregion

      
       
    }
}