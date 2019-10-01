namespace WindowsFormsApp1
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
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.chkVecera = new System.Windows.Forms.CheckBox();
            this.chkSakrij = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(291, 29);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(324, 280);
            this.txtPrikaz.TabIndex = 0;
            this.txtPrikaz.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(110, 123);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(67, 17);
            this.chkDorucak.TabIndex = 1;
            this.chkDorucak.Text = "Doručak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(110, 183);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(58, 17);
            this.chkRucak.TabIndex = 2;
            this.chkRucak.Text = "Ručak";
            this.chkRucak.UseVisualStyleBackColor = true;
            // 
            // chkVecera
            // 
            this.chkVecera.AutoSize = true;
            this.chkVecera.Location = new System.Drawing.Point(110, 238);
            this.chkVecera.Name = "chkVecera";
            this.chkVecera.Size = new System.Drawing.Size(60, 17);
            this.chkVecera.TabIndex = 3;
            this.chkVecera.Text = "Večera";
            this.chkVecera.UseVisualStyleBackColor = true;
            // 
            // chkSakrij
            // 
            this.chkSakrij.AutoSize = true;
            this.chkSakrij.Location = new System.Drawing.Point(291, 333);
            this.chkSakrij.Name = "chkSakrij";
            this.chkSakrij.Size = new System.Drawing.Size(99, 17);
            this.chkSakrij.TabIndex = 4;
            this.chkSakrij.Text = "Sakrij narudžbu";
            this.chkSakrij.UseVisualStyleBackColor = true;
            this.chkSakrij.CheckedChanged += new System.EventHandler(this.ChkSakrij_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(291, 356);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(324, 72);
            this.btnPosalji.TabIndex = 5;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.BtnPosalji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.chkSakrij);
            this.Controls.Add(this.chkVecera);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkDorucak);
            this.Controls.Add(this.txtPrikaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.CheckBox chkVecera;
        private System.Windows.Forms.CheckBox chkSakrij;
        private System.Windows.Forms.Button btnPosalji;
    }
}

