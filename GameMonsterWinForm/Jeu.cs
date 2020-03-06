using System;
using System.Windows.Forms;
using TPjeu;

namespace GameMonsterWinForm
{
    public partial class Niveaux : Form
    {
        public Niveaux()
        {
            InitializeComponent();
        }

        #region deuxieme fenetre

        private void choixNiveaux_Click(object sender, EventArgs e)
        {
            Form1 gameMonster = new Form1();
            gameMonster.Show();
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