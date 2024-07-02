namespace Magazin_telefoane
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNumeUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.Utilizator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConectare = new System.Windows.Forms.Button();
            this.buttonAnulare = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumeUtilizator
            // 
            this.textBoxNumeUtilizator.Location = new System.Drawing.Point(78, 37);
            this.textBoxNumeUtilizator.Name = "textBoxNumeUtilizator";
            this.textBoxNumeUtilizator.Size = new System.Drawing.Size(303, 22);
            this.textBoxNumeUtilizator.TabIndex = 0;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(78, 66);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(303, 22);
            this.textBoxParola.TabIndex = 1;
            // 
            // Utilizator
            // 
            this.Utilizator.AutoSize = true;
            this.Utilizator.Location = new System.Drawing.Point(14, 40);
            this.Utilizator.Name = "Utilizator";
            this.Utilizator.Size = new System.Drawing.Size(58, 16);
            this.Utilizator.TabIndex = 2;
            this.Utilizator.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // buttonConectare
            // 
            this.buttonConectare.Location = new System.Drawing.Point(78, 113);
            this.buttonConectare.Name = "buttonConectare";
            this.buttonConectare.Size = new System.Drawing.Size(122, 36);
            this.buttonConectare.TabIndex = 4;
            this.buttonConectare.Text = "Conectare";
            this.buttonConectare.UseVisualStyleBackColor = true;
            this.buttonConectare.Click += new System.EventHandler(this.buttonConectare_Click);
            // 
            // buttonAnulare
            // 
            this.buttonAnulare.Location = new System.Drawing.Point(259, 113);
            this.buttonAnulare.Name = "buttonAnulare";
            this.buttonAnulare.Size = new System.Drawing.Size(122, 36);
            this.buttonAnulare.TabIndex = 5;
            this.buttonAnulare.Text = "Anulare";
            this.buttonAnulare.UseVisualStyleBackColor = true;
            this.buttonAnulare.Click += new System.EventHandler(this.buttonAnulare_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 204);
            this.Controls.Add(this.buttonAnulare);
            this.Controls.Add(this.buttonConectare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Utilizator);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxNumeUtilizator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeUtilizator;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label Utilizator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConectare;
        private System.Windows.Forms.Button buttonAnulare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

