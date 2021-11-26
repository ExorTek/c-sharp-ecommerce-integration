
namespace DemoFormUI
{
    partial class SelectAPI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTsoftApi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTsoftApi
            // 
            this.btnTsoftApi.Location = new System.Drawing.Point(75, 19);
            this.btnTsoftApi.Name = "btnTsoftApi";
            this.btnTsoftApi.Size = new System.Drawing.Size(223, 68);
            this.btnTsoftApi.TabIndex = 0;
            this.btnTsoftApi.Text = "T-Soft Entegrasyon";
            this.btnTsoftApi.UseVisualStyleBackColor = true;
            this.btnTsoftApi.Click += new System.EventHandler(this.btnTsoftApi_Click);
            // 
            // SelectAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 99);
            this.Controls.Add(this.btnTsoftApi);
            this.Name = "SelectAPI";
            this.Text = "Entegrasyon Seçimi Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTsoftApi;
    }
}

