namespace GameMonsterWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.degatsEpeeBoss = new System.Windows.Forms.NumericUpDown();
            this.armureHero = new System.Windows.Forms.NumericUpDown();
            this.bossPV = new System.Windows.Forms.NumericUpDown();
            this.heroPV = new System.Windows.Forms.NumericUpDown();
            this.nomHero = new System.Windows.Forms.TextBox();
            this.creeBoss = new System.Windows.Forms.Button();
            this.creeHero = new System.Windows.Forms.Button();
            this.nomBoss = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.degatsEpeeHero = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Button();
            Form1.combat = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.degatsEpeeBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.armureHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bossPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heroPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.degatsEpeeHero)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDe
            // 
            this.buttonDe.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonDe.ForeColor = System.Drawing.Color.Black;
            this.buttonDe.Image = ((System.Drawing.Image) (resources.GetObject("buttonDe.Image")));
            this.buttonDe.Location = new System.Drawing.Point(874, 42);
            this.buttonDe.Name = "buttonDe";
            this.buttonDe.Size = new System.Drawing.Size(212, 201);
            this.buttonDe.TabIndex = 63;
            this.buttonDe.Text = "Lancer le dé de degats";
            this.buttonDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDe.UseVisualStyleBackColor = true;
            this.buttonDe.Click += new System.EventHandler(this.buttonDe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.buttonDe);
            this.groupBox1.Controls.Add(this.degatsEpeeBoss);
            this.groupBox1.Controls.Add(this.armureHero);
            this.groupBox1.Controls.Add(this.bossPV);
            this.groupBox1.Controls.Add(this.heroPV);
            this.groupBox1.Controls.Add(this.nomHero);
            this.groupBox1.Controls.Add(this.creeBoss);
            this.groupBox1.Controls.Add(this.creeHero);
            this.groupBox1.Controls.Add(this.nomBoss);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.degatsEpeeHero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 329);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "création des personnages";
            // 
            // degatsEpeeBoss
            // 
            this.degatsEpeeBoss.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.degatsEpeeBoss.Increment = new decimal(new int[] {5, 0, 0, 0});
            this.degatsEpeeBoss.Location = new System.Drawing.Point(716, 168);
            this.degatsEpeeBoss.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.degatsEpeeBoss.Name = "degatsEpeeBoss";
            this.degatsEpeeBoss.Size = new System.Drawing.Size(141, 25);
            this.degatsEpeeBoss.TabIndex = 96;
            this.degatsEpeeBoss.ThousandsSeparator = true;
            this.degatsEpeeBoss.ValueChanged += new System.EventHandler(this.degatsEpeeBoss_ValueChanged);
            // 
            // armureHero
            // 
            this.armureHero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.armureHero.Increment = new decimal(new int[] {5, 0, 0, 0});
            this.armureHero.Location = new System.Drawing.Point(545, 110);
            this.armureHero.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.armureHero.Name = "armureHero";
            this.armureHero.Size = new System.Drawing.Size(141, 25);
            this.armureHero.TabIndex = 95;
            this.armureHero.ThousandsSeparator = true;
            this.armureHero.ValueChanged += new System.EventHandler(this.armureHero_ValueChanged);
            // 
            // bossPV
            // 
            this.bossPV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bossPV.Increment = new decimal(new int[] {10, 0, 0, 0});
            this.bossPV.Location = new System.Drawing.Point(371, 167);
            this.bossPV.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.bossPV.Name = "bossPV";
            this.bossPV.Size = new System.Drawing.Size(141, 25);
            this.bossPV.TabIndex = 94;
            this.bossPV.ThousandsSeparator = true;
            this.bossPV.ValueChanged += new System.EventHandler(this.bossPV_ValueChanged);
            // 
            // heroPV
            // 
            this.heroPV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.heroPV.Increment = new decimal(new int[] {10, 0, 0, 0});
            this.heroPV.Location = new System.Drawing.Point(371, 110);
            this.heroPV.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.heroPV.Name = "heroPV";
            this.heroPV.Size = new System.Drawing.Size(141, 25);
            this.heroPV.TabIndex = 93;
            this.heroPV.ThousandsSeparator = true;
            this.heroPV.ValueChanged += new System.EventHandler(this.heroPV_ValueChanged);
            // 
            // nomHero
            // 
            this.nomHero.Location = new System.Drawing.Point(196, 110);
            this.nomHero.Name = "nomHero";
            this.nomHero.Size = new System.Drawing.Size(129, 25);
            this.nomHero.TabIndex = 92;
            this.nomHero.TextChanged += new System.EventHandler(this.nomHero_TextChanged);
            // 
            // creeBoss
            // 
            this.creeBoss.BackColor = System.Drawing.Color.Red;
            this.creeBoss.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.creeBoss.Location = new System.Drawing.Point(24, 157);
            this.creeBoss.Name = "creeBoss";
            this.creeBoss.Size = new System.Drawing.Size(136, 40);
            this.creeBoss.TabIndex = 91;
            this.creeBoss.Text = "création boss";
            this.creeBoss.UseVisualStyleBackColor = false;
            this.creeBoss.Click += new System.EventHandler(this.creeBoss_Click);
            // 
            // creeHero
            // 
            this.creeHero.BackColor = System.Drawing.Color.CornflowerBlue;
            this.creeHero.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.creeHero.Location = new System.Drawing.Point(24, 99);
            this.creeHero.Name = "creeHero";
            this.creeHero.Size = new System.Drawing.Size(136, 40);
            this.creeHero.TabIndex = 90;
            this.creeHero.Text = "création hero";
            this.creeHero.UseVisualStyleBackColor = false;
            this.creeHero.Click += new System.EventHandler(this.creeHero_Click);
            // 
            // nomBoss
            // 
            this.nomBoss.Location = new System.Drawing.Point(196, 168);
            this.nomBoss.Name = "nomBoss";
            this.nomBoss.Size = new System.Drawing.Size(129, 25);
            this.nomBoss.TabIndex = 88;
            this.nomBoss.TextChanged += new System.EventHandler(this.nomBoss_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.Location = new System.Drawing.Point(545, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 16);
            this.textBox1.TabIndex = 89;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))),
                ((int) (((byte) (0)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(716, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 31);
            this.label4.TabIndex = 86;
            this.label4.Text = "Dégats d\'arme";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // degatsEpeeHero
            // 
            this.degatsEpeeHero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.degatsEpeeHero.Increment = new decimal(new int[] {5, 0, 0, 0});
            this.degatsEpeeHero.Location = new System.Drawing.Point(716, 108);
            this.degatsEpeeHero.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.degatsEpeeHero.Name = "degatsEpeeHero";
            this.degatsEpeeHero.Size = new System.Drawing.Size(141, 25);
            this.degatsEpeeHero.TabIndex = 87;
            this.degatsEpeeHero.ThousandsSeparator = true;
            this.degatsEpeeHero.ValueChanged += new System.EventHandler(this.degatsEpeeHero_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))),
                ((int) (((byte) (224)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(196, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(371, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 84;
            this.label2.Text = "PV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(545, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 83;
            this.label1.Text = "Points d\'armure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end
            // 
            this.end.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("end.BackgroundImage")));
            this.end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.end.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.end.Location = new System.Drawing.Point(968, 423);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(157, 196);
            this.end.TabIndex = 81;
            this.end.Text = "fin de partie";
            this.end.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // combat
            // 
            Form1.combat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            Form1.combat.BackColor = System.Drawing.Color.Silver;
            Form1.combat.Location = new System.Drawing.Point(13, 357);
            Form1.combat.Multiline = true;
            Form1.combat.Name = "combat";
            Form1.combat.Size = new System.Drawing.Size(927, 348);
            Form1.combat.TabIndex = 83;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 717);
            this.Controls.Add(Form1.combat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.end);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMonster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.degatsEpeeBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.armureHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bossPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heroPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.degatsEpeeHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown degatsEpeeHero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nomBoss;
        private System.Windows.Forms.Button creeHero;
        private System.Windows.Forms.Button creeBoss;
        private System.Windows.Forms.TextBox nomHero;
        private System.Windows.Forms.NumericUpDown heroPV;
        private System.Windows.Forms.NumericUpDown bossPV;
        private System.Windows.Forms.NumericUpDown armureHero;
        private System.Windows.Forms.NumericUpDown degatsEpeeBoss;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDe;
        public static System.Windows.Forms.TextBox combat;
    }
}