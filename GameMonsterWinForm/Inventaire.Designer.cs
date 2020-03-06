using System.ComponentModel;

namespace GameMonsterWinForm
{
    partial class Inventaire
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Armure1 = new System.Windows.Forms.Button();
            this.vie1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fermer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Armure1);
            this.groupBox1.Controls.Add(this.vie1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Potion";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(261, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Effet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Armure1
            // 
            this.Armure1.Location = new System.Drawing.Point(251, 110);
            this.Armure1.Name = "Armure1";
            this.Armure1.Size = new System.Drawing.Size(110, 33);
            this.Armure1.TabIndex = 3;
            this.Armure1.Text = "+ 50";
            this.Armure1.UseVisualStyleBackColor = true;
            this.Armure1.Click += new System.EventHandler(this.button2_Click);
            // 
            // vie1
            // 
            this.vie1.Location = new System.Drawing.Point(251, 59);
            this.vie1.Name = "vie1";
            this.vie1.Size = new System.Drawing.Size(110, 33);
            this.vie1.TabIndex = 2;
            this.vie1.Text = "+ 50";
            this.vie1.UseVisualStyleBackColor = true;
            this.vie1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Armure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "PV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fermer
            // 
            this.fermer.Font = new System.Drawing.Font("Segoe UI", 9.75F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.fermer.Location = new System.Drawing.Point(263, 239);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(126, 39);
            this.fermer.TabIndex = 1;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(472, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fermer);
            this.Name = "Inventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button vie1;
        private System.Windows.Forms.Button Armure1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}