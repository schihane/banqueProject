﻿namespace Gestion_de_Banque
{
    partial class Ajouter_Movement
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
            this.Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Date_Mouvement = new System.Windows.Forms.DateTimePicker();
            this.Numero_Compte = new System.Windows.Forms.ComboBox();
            this.Type_Mouvement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(496, 119);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 15;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ajouter Mouvement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date Movement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(251, 172);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 20);
            this.Montant.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero Compte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type Movement";
            // 
            // Date_Mouvement
            // 
            this.Date_Mouvement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Mouvement.Location = new System.Drawing.Point(253, 268);
            this.Date_Mouvement.Name = "Date_Mouvement";
            this.Date_Mouvement.Size = new System.Drawing.Size(200, 20);
            this.Date_Mouvement.TabIndex = 20;
            // 
            // Numero_Compte
            // 
            this.Numero_Compte.FormattingEnabled = true;
            this.Numero_Compte.Location = new System.Drawing.Point(251, 126);
            this.Numero_Compte.Name = "Numero_Compte";
            this.Numero_Compte.Size = new System.Drawing.Size(102, 21);
            this.Numero_Compte.TabIndex = 21;
            // 
            // Type_Mouvement
            // 
            this.Type_Mouvement.FormattingEnabled = true;
            this.Type_Mouvement.Items.AddRange(new object[] {
            "retrait",
            "dépôt"});
            this.Type_Mouvement.Location = new System.Drawing.Point(253, 221);
            this.Type_Mouvement.Name = "Type_Mouvement";
            this.Type_Mouvement.Size = new System.Drawing.Size(102, 21);
            this.Type_Mouvement.TabIndex = 22;
            // 
            // Ajouter_Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Type_Mouvement);
            this.Controls.Add(this.Numero_Compte);
            this.Controls.Add(this.Date_Mouvement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_Movement";
            this.Text = "Ajouter_Movement";
            this.Load += new System.EventHandler(this.Ajouter_Movement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Date_Mouvement;
        private System.Windows.Forms.ComboBox Numero_Compte;
        private System.Windows.Forms.ComboBox Type_Mouvement;
    }
}