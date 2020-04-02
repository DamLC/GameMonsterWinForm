using System.ComponentModel;

namespace GameMonsterWinForm
{
    partial class Niveaux
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Niveaux));
            this.end = new System.Windows.Forms.Button();
            this.choixNiveaux = new System.Windows.Forms.Button();
            Niveaux.combat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // end
            // 
            this.end.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("end.BackgroundImage")));
            this.end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.end.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.end.Location = new System.Drawing.Point(205, 377);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(157, 174);
            this.end.TabIndex = 98;
            this.end.Text = "fin de partie";
            this.end.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // choixNiveaux
            // 
            this.choixNiveaux.BackColor = System.Drawing.Color.Yellow;
            this.choixNiveaux.Location = new System.Drawing.Point(12, 432);
            this.choixNiveaux.Name = "choixNiveaux";
            this.choixNiveaux.Size = new System.Drawing.Size(159, 45);
            this.choixNiveaux.TabIndex = 99;
            this.choixNiveaux.Text = "choix du niveaux";
            this.choixNiveaux.UseVisualStyleBackColor = false;
            this.choixNiveaux.Click += new System.EventHandler(this.choixNiveaux_Click);
            // 
            // combat
            // 
            Niveaux.combat.BackColor = System.Drawing.Color.White;
            Niveaux.combat.Location = new System.Drawing.Point(12, 12);
            Niveaux.combat.Multiline = true;
            Niveaux.combat.Name = "combat";
            Niveaux.combat.Size = new System.Drawing.Size(350, 348);
            Niveaux.combat.TabIndex = 100;
            Niveaux.combat.Text = resources.GetString("combat.Text");
            Niveaux.combat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Niveaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))),
                ((int) (((byte) (224)))));
            this.ClientSize = new System.Drawing.Size(396, 563);
            this.Controls.Add(Niveaux.combat);
            this.Controls.Add(this.end);
            this.Controls.Add(this.choixNiveaux);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "Niveaux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jeu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button choixNiveaux;
        private System.Windows.Forms.Button end;
        public static System.Windows.Forms.TextBox combat;
    }
}