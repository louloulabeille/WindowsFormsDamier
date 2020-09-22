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
            this.listBoxColorClair = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNbLigne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelDamier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taille du damier en nombre de ligne:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Creation du Damier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EventCreationDamier);
            // 
            // textBoxNbColonne
            // 
            this.textBoxNbColonne.Location = new System.Drawing.Point(152, 37);
            this.textBoxNbColonne.Name = "textBoxNbColonne";
            this.textBoxNbColonne.Size = new System.Drawing.Size(100, 22);
            this.textBoxNbColonne.TabIndex = 2;
            // 
            // panelDamier
            // 
            this.panelDamier.AutoScroll = true;
            this.panelDamier.Controls.Add(this.listBox1);
            this.panelDamier.Location = new System.Drawing.Point(16, 101);
            this.panelDamier.Name = "panelDamier";
            this.panelDamier.Size = new System.Drawing.Size(971, 486);
            this.panelDamier.TabIndex = 4;
            // 
            // listBoxColorClair
            // 
            this.listBoxColorClair.FormattingEnabled = true;
            this.listBoxColorClair.ItemHeight = 16;
            this.listBoxColorClair.Location = new System.Drawing.Point(6, 25);
            this.listBoxColorClair.Name = "listBoxColorClair";
            this.listBoxColorClair.Size = new System.Drawing.Size(188, 52);
            this.listBoxColorClair.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxColorClair);
            this.groupBox1.Location = new System.Drawing.Point(279, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix couleur clair";
            // 
            // textBoxNbLigne
            // 
            this.textBoxNbLigne.Location = new System.Drawing.Point(152, 70);
            this.textBoxNbLigne.Name = "textBoxNbLigne";
            this.textBoxNbLigne.Size = new System.Drawing.Size(100, 22);
            this.textBoxNbLigne.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre de colonne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre de ligne:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(507, -68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 52);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(521, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix couleur foncé";
            // 
            // FormDamier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNbLigne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelDamier);
            this.Controls.Add(this.textBoxNbColonne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormDamier";
            this.Text = "Damier";
            this.panelDamier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
    }
}

