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


        private bool active = false;

        #region deuxieme fenetre

        private void choixNiveaux_Click(object sender, EventArgs e)
        {
            if (active != true)
            {
                Form1 gameMonster = new Form1();
                gameMonster.Show();
                active = true;
            }
            else
            {
                MessageBox.Show("cette fenêtre est déja ouverte");
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