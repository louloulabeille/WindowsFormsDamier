namespace WindowsFormsDamier
{
    partial class FormDamier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNbColonne = new System.Windows.Forms.TextBox();
            this.panelDamier = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBoxColorClair = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNbLigne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxColorFonce = new System.Windows.Forms.ListBox();
            this.panelDamier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taille du damier";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Creation du Damier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EventCreationDamier);
            // 
            // textBoxNbColonne
            // 
            this.textBoxNbColonne.Location = new System.Drawing.Point(114, 30);
            this.textBoxNbColonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNbColonne.Name = "textBoxNbColonne";
            this.textBoxNbColonne.Size = new System.Drawing.Size(76, 20);
            this.textBoxNbColonne.TabIndex = 2;
            this.textBoxNbColonne.TextChanged += new System.EventHandler(this.EventTextBoxModifier);
            // 
            // panelDamier
            // 
            this.panelDamier.AutoScroll = true;
            this.panelDamier.Controls.Add(this.listBox1);
            this.panelDamier.Location = new System.Drawing.Point(12, 82);
            this.panelDamier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDamier.Name = "panelDamier";
            this.panelDamier.Size = new System.Drawing.Size(728, 395);
            this.panelDamier.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(380, -55);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 43);
            this.listBox1.TabIndex = 0;
            // 
            // listBoxColorClair
            // 
            this.listBoxColorClair.FormattingEnabled = true;
            this.listBoxColorClair.Location = new System.Drawing.Point(4, 20);
            this.listBoxColorClair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxColorClair.Name = "listBoxColorClair";
            this.listBoxColorClair.Size = new System.Drawing.Size(142, 43);
            this.listBoxColorClair.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxColorClair);
            this.groupBox1.Location = new System.Drawing.Point(209, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix couleur clair";
            // 
            // textBoxNbLigne
            // 
            this.textBoxNbLigne.Location = new System.Drawing.Point(114, 57);
            this.textBoxNbLigne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNbLigne.Name = "textBoxNbLigne";
            this.textBoxNbLigne.Size = new System.Drawing.Size(76, 20);
            this.textBoxNbLigne.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de colonne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre de ligne:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxColorFonce);
            this.groupBox2.Location = new System.Drawing.Point(391, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 67);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix couleur foncé";
            // 
            // listBoxColorFonce
            // 
            this.listBoxColorFonce.FormattingEnabled = true;
            this.listBoxColorFonce.Location = new System.Drawing.Point(4, 20);
            this.listBoxColorFonce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxColorFonce.Name = "listBoxColorFonce";
            this.listBoxColorFonce.Size = new System.Drawing.Size(142, 43);
            this.listBoxColorFonce.TabIndex = 0;
            // 
            // FormDamier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNbLigne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDamier);
            this.Controls.Add(this.textBoxNbColonne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDamier";
            this.Text = "Damier";
            this.panelDamier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNbColonne;
        private System.Windows.Forms.Panel panelDamier;
        private System.Windows.Forms.ListBox listBoxColorClair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNbLigne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxColorFonce;
    }
}

