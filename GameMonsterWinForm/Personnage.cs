using System;
using System.Windows.Forms;
using TPjeu;
using TPjeu.Monstres;
using TPjeu.Personnages;

namespace GameMonsterWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Boolean vérification

        public static bool _niveau1 = false;
        public static bool _niveauF = false;
        public static bool active = false;
        public static bool heroCree = false;
        public static bool bossCree = false;
        
        #endregion 
        
        #region Compteur

        int xp = 0;
        int cptFacile = 0;
        int cptDifficile = 0;

        #endregion
        
        #region Attribut Hero

        public static Joueur hero;
        private string nomDuHero;
        private static decimal vieHero;
        private decimal armureDuHero;
        private decimal degatsHero;

        #endregion
        
        #region Attribut Boss

        public static Boss _boss;
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
                    Niveaux.combat.AppendText(" Notre hero " +
                                                    nomDuHero + " a été créer! \n " +
                                                    vieHero + " PV\n " +
                                                    armureDuHero + " Pts d'armure\n " +
                                                    degatsHero + " dégats d'épée \n");
                    Niveaux.combat.AppendText(Narration.espace());

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
                    Niveaux.combat.AppendText("Le boss " +
                                                    nomDuBoss + " a été créer! \n " +
                                                    vieBoss + " PV\n " +
                                                    degatsBoss + " dégats d'épée \n");
                    Niveaux.combat.AppendText(Narration.espace());

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

        private void buttonDe_Click(object sender, EventArgs click)
        {
            try
            {
                if (_niveau1 == true)
                {
                    if (hero.estVivant == true)
                    {
                        MonstreFacile monstre = FabriqueMonstre.creerMonstre();
                                       
                        if (monstre.estVivant == true && hero.estVivant == true)
                        {
                            hero.attaque(monstre);
                                                           
                            if (monstre.estVivant)
                            {
                                monstre.attaque(hero);
                                                           
                                if (hero.estVivant)
                                {
                                    if (monstre is MonstreFacile)
                                    {
                                        cptFacile++;
                                        xp += 1 ;
                                    }
                                    if(monstre is MonstreDifficile)
                                    {
                                        cptDifficile++;
                                        xp += 2;
                                    }
                                }
                                else
                                {
                                    Niveaux.combat.AppendText(DialogueJoueur.mortMonstre());
                                    Niveaux.combat.AppendText(Narration.espace());                           
                                    Niveaux.combat.AppendText("Bravo! tu as tué "+cptFacile+" monstres faciles " +
                                                                    " et "+cptDifficile+" monstres difficiles. tu as gagné "+xp+" xp.\n");
                                    Niveaux.combat.AppendText(Narration.espace());                           

                                    Niveaux.combat.AppendText(Joueur.levelUp(xp));
                                    Niveaux.combat.AppendText(Narration.espace());

                                    Niveaux.combat.AppendText(Narration.fin());
                                    Niveaux.combat.AppendText(Narration.espace());

                                    Niveaux.combat.AppendText(Narration.deuxiemeChance()); 
                                    Niveaux.combat.AppendText(Narration.espace());   
                                }
                            }
                        }
                    }
                }
                if (_niveauF == true)
                {
                    if(hero.estVivant && _boss.estVivant)
                    {
                        hero.attaque(_boss);
                        Niveaux.combat.AppendText(Narration.espace());
                                                            
                                       
                        _boss.attaque(hero);
                        Niveaux.combat.AppendText(Narration.espace());
                    } 
                    if( _boss.estVivant && !hero.estVivant)
                    {
                        Niveaux.combat.AppendText(DialogueJoueur.deuxiemeMort()) ;
                        Niveaux.combat.AppendText(DialogueBoss.tueJoueur());
                        Niveaux.combat.AppendText(Narration.fin3());
                        Niveaux.combat.AppendText(Narration.fin());
                    }
                    if(hero.estVivant && !_boss.estVivant)
                    {
                        Niveaux.combat.AppendText(DialogueJoueur.tueBoss());
                        Niveaux.combat.AppendText(Narration.fin2());
                    }  
                }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Pour lancer le dé il faut :\n soit choisir le niveau I et créer un hero\n" +
                                "soit choisir le niveau final," +
                                " créer un héro, créer un boss ");
            }
        }

        #endregion

        #region Niveaux

        private void niveau1_Click(object sender, EventArgs e)
        {
            try
            {
                if (heroCree != true)
                { 
                    Niveaux.combat.AppendText(Narration.espace());
                    Niveaux.combat.AppendText("crée un hero et reclick le bouton pour la narration\n");
                }
                else
                {
                    _niveau1 = true;
                    Niveaux.combat.AppendText(Narration.debut()) ;
                    Niveaux.combat.AppendText(Narration.espace());  
                                    
                    Niveaux.combat.AppendText(Narration.arrivee()); 
                    Niveaux.combat.AppendText(Narration.espace());
               
                    Niveaux.combat.AppendText(Narration.niveau());
                    Niveaux.combat.AppendText(Narration.espace());                           
               
                                                                  
                    Niveaux.combat.AppendText(Narration.combat());
                    Niveaux.combat.AppendText(Narration.espace()); 
                    
                    Niveaux.combat.AppendText(Narration.espace());
                    Niveaux.combat.AppendText("Lance le d pour commencer la partie");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pour attaquer il faut choisir un niveaux");
            }

        }
       
        private void niveauFinal_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (bossCree != true && heroCree != true)
                {
                    Niveaux.combat.AppendText(Narration.espace());
                    Niveaux.combat.AppendText("crée un hero, un boss et lance le dé\n") ;
                }
               
            }
            catch (Exception )
            {
                _niveauF = true;
                Niveaux.combat.AppendText("");
            }
            
        }
         

        #endregion
        
        #region fenetre inventaire

        private void inventaire_Click(object sender, EventArgs e)
        {
            if (active != true)
            {
                Inventaire inventaire = new Inventaire();
                inventaire.Show();
                active = true;
            }
            else
            {
                MessageBox.Show("cette fenêtre est déja ouverte");
            }
        }

        #endregion

       
    }
}