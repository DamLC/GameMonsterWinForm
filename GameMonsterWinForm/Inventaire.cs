using System;
using System.Windows.Forms;
using TPjeu.Personnages;
using TPjeu.Protections;

namespace GameMonsterWinForm
{
    public partial class Inventaire : Form
    {
        public Inventaire()
        {
            InitializeComponent();
        }

        #region Potion
        private void button1_Click(object sender, EventArgs e)
        {
            Joueur.soigner();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Armure.soigner();
        }

        #endregion
       
        #region Fermer

        private void fermer_Click(object sender, EventArgs e)
        {
            Inventaire.ActiveForm.Close();
            Form1.active = false;
        }

        #endregion
       
    }
}