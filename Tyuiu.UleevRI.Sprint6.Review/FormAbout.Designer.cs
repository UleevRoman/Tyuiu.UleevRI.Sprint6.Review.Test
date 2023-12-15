
namespace Tyuiu.UleevRI.Sprint6.Review
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxInformation_URI = new System.Windows.Forms.PictureBox();
            this.textBoxInformation_URI = new System.Windows.Forms.TextBox();
            this.buttonOK_URI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInformation_URI
            // 
            this.pictureBoxInformation_URI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInformation_URI.Image")));
            this.pictureBoxInformation_URI.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxInformation_URI.Name = "pictureBoxInformation_URI";
            this.pictureBoxInformation_URI.Size = new System.Drawing.Size(223, 218);
            this.pictureBoxInformation_URI.TabIndex = 0;
            this.pictureBoxInformation_URI.TabStop = false;
            // 
            // textBoxInformation_URI
            // 
            this.textBoxInformation_URI.Location = new System.Drawing.Point(253, 13);
            this.textBoxInformation_URI.Multiline = true;
            this.textBoxInformation_URI.Name = "textBoxInformation_URI";
            this.textBoxInformation_URI.ReadOnly = true;
            this.textBoxInformation_URI.Size = new System.Drawing.Size(492, 193);
            this.textBoxInformation_URI.TabIndex = 1;
            // 
            // buttonOK_URI
            // 
            this.buttonOK_URI.Location = new System.Drawing.Point(669, 384);
            this.buttonOK_URI.Name = "buttonOK_URI";
            this.buttonOK_URI.Size = new System.Drawing.Size(119, 54);
            this.buttonOK_URI.TabIndex = 2;
            this.buttonOK_URI.Text = "OK";
            this.buttonOK_URI.UseVisualStyleBackColor = true;
            this.buttonOK_URI.Click += new System.EventHandler(this.buttonOK_URI_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOK_URI);
            this.Controls.Add(this.textBoxInformation_URI);
            this.Controls.Add(this.pictureBoxInformation_URI);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformation_URI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInformation_URI;
        private System.Windows.Forms.TextBox textBoxInformation_URI;
        private System.Windows.Forms.Button buttonOK_URI;
    }
}