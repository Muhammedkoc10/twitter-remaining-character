
namespace DialogForm
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
            this.btnDialogForm = new System.Windows.Forms.Button();
            this.btnNormalForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialogForm
            // 
            this.btnDialogForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDialogForm.Location = new System.Drawing.Point(61, 26);
            this.btnDialogForm.Name = "btnDialogForm";
            this.btnDialogForm.Size = new System.Drawing.Size(211, 113);
            this.btnDialogForm.TabIndex = 0;
            this.btnDialogForm.Text = "DİALOG FORM AÇ";
            this.btnDialogForm.UseVisualStyleBackColor = true;
            this.btnDialogForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNormalForm
            // 
            this.btnNormalForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalForm.Location = new System.Drawing.Point(61, 181);
            this.btnNormalForm.Name = "btnNormalForm";
            this.btnNormalForm.Size = new System.Drawing.Size(211, 113);
            this.btnNormalForm.TabIndex = 0;
            this.btnNormalForm.Text = "NORMAL FORM AÇ";
            this.btnNormalForm.UseVisualStyleBackColor = true;
            this.btnNormalForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 376);
            this.Controls.Add(this.btnNormalForm);
            this.Controls.Add(this.btnDialogForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialogForm;
        private System.Windows.Forms.Button btnNormalForm;
    }
}

