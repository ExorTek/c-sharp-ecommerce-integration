
namespace DemoFormUI
{
    partial class TSoftMainFrm
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
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.dgwViewProduct = new System.Windows.Forms.DataGridView();
            this.btnTransferData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Location = new System.Drawing.Point(12, 382);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(117, 56);
            this.btnGetProduct.TabIndex = 0;
            this.btnGetProduct.Text = "Ürün Görüntüle";
            this.btnGetProduct.UseVisualStyleBackColor = true;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // dgwViewProduct
            // 
            this.dgwViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwViewProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwViewProduct.Name = "dgwViewProduct";
            this.dgwViewProduct.RowHeadersWidth = 51;
            this.dgwViewProduct.RowTemplate.Height = 29;
            this.dgwViewProduct.Size = new System.Drawing.Size(861, 364);
            this.dgwViewProduct.TabIndex = 1;
            // 
            // btnTransferData
            // 
            this.btnTransferData.Location = new System.Drawing.Point(151, 382);
            this.btnTransferData.Name = "btnTransferData";
            this.btnTransferData.Size = new System.Drawing.Size(111, 56);
            this.btnTransferData.TabIndex = 2;
            this.btnTransferData.Text = "Ürünleri Aktar";
            this.btnTransferData.UseVisualStyleBackColor = true;
            this.btnTransferData.Click += new System.EventHandler(this.button1_Click);
            // 
            // TSoftMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.btnTransferData);
            this.Controls.Add(this.dgwViewProduct);
            this.Controls.Add(this.btnGetProduct);
            this.Name = "TSoftMainFrm";
            this.Text = "T-Soft Ürün Entegre";
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.DataGridView dgwViewProduct;
        private System.Windows.Forms.Button btnTransferData;
    }
}