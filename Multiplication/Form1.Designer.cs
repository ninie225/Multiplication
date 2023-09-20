
namespace Multiplication
{
    partial class Form1
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
            this.grpQuest = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnRefaire = new System.Windows.Forms.Button();
            this.lblOperation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpQuest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQuest
            // 
            this.grpQuest.Controls.Add(this.label2);
            this.grpQuest.Controls.Add(this.label1);
            this.grpQuest.Controls.Add(this.lblOperation);
            this.grpQuest.Controls.Add(this.btnSuivant);
            this.grpQuest.Controls.Add(this.n1);
            this.grpQuest.Controls.Add(this.n2);
            this.grpQuest.Controls.Add(this.result);
            this.grpQuest.Location = new System.Drawing.Point(25, 21);
            this.grpQuest.Name = "grpQuest";
            this.grpQuest.Size = new System.Drawing.Size(208, 100);
            this.grpQuest.TabIndex = 0;
            this.grpQuest.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Location = new System.Drawing.Point(25, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Note";
            // 
            // n1
            // 
            this.n1.Enabled = false;
            this.n1.Location = new System.Drawing.Point(6, 21);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(33, 22);
            this.n1.TabIndex = 1;
            this.n1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n2
            // 
            this.n2.Enabled = false;
            this.n2.Location = new System.Drawing.Point(82, 21);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(33, 22);
            this.n2.TabIndex = 2;
            this.n2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(159, 21);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(31, 22);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.result.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.result_KeyPress);
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(6, 32);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(33, 22);
            this.txtNote.TabIndex = 4;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.HideSelection = false;
            this.textBox5.Location = new System.Drawing.Point(82, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(33, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "20";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(115, 59);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(75, 23);
            this.btnSuivant.TabIndex = 6;
            this.btnSuivant.Text = "suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnRefaire
            // 
            this.btnRefaire.Location = new System.Drawing.Point(158, 138);
            this.btnRefaire.Name = "btnRefaire";
            this.btnRefaire.Size = new System.Drawing.Size(75, 71);
            this.btnRefaire.TabIndex = 7;
            this.btnRefaire.TabStop = false;
            this.btnRefaire.Text = "Refaire le test";
            this.btnRefaire.UseVisualStyleBackColor = true;
            this.btnRefaire.Click += new System.EventHandler(this.btnRefaire_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(6, 65);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(0, 17);
            this.lblOperation.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = " X ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = " = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = " / ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 236);
            this.Controls.Add(this.btnRefaire);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpQuest);
            this.Name = "Form1";
            this.Text = "T.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpQuest.ResumeLayout(false);
            this.grpQuest.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnRefaire;
    }
}

