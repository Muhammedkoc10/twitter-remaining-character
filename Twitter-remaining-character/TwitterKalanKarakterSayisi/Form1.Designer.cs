
namespace TwitterKalanKarakterSayisi
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
            this.txtGirileMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKarakter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGirileMetin
            // 
            this.txtGirileMetin.Location = new System.Drawing.Point(72, 55);
            this.txtGirileMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGirileMetin.Multiline = true;
            this.txtGirileMetin.Name = "txtGirileMetin";
            this.txtGirileMetin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGirileMetin.Size = new System.Drawing.Size(291, 131);
            this.txtGirileMetin.TabIndex = 0;
            this.txtGirileMetin.TextChanged += new System.EventHandler(this.txtGirileMetin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalan Karakter Sayısı :";
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.Location = new System.Drawing.Point(242, 225);
            this.lblKarakter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(36, 20);
            this.lblKarakter.TabIndex = 2;
            this.lblKarakter.Text = "450";
            this.lblKarakter.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.lblKarakter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGirileMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirileMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKarakter;
    }
}

