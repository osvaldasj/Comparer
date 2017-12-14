namespace Comparer
{
    partial class DataReview
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
            this.dataGridViewAllProducts = new System.Windows.Forms.DataGridView();
            this.LoadAllProductsData = new System.Windows.Forms.Button();
            this.textBoxRecentPricesChanges = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllProducts
            // 
            this.dataGridViewAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProducts.Location = new System.Drawing.Point(124, 5);
            this.dataGridViewAllProducts.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewAllProducts.Name = "dataGridViewAllProducts";
            this.dataGridViewAllProducts.RowTemplate.Height = 40;
            this.dataGridViewAllProducts.Size = new System.Drawing.Size(172, 364);
            this.dataGridViewAllProducts.TabIndex = 0;
            // 
            // LoadAllProductsData
            // 
            this.LoadAllProductsData.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.LoadAllProductsData.Location = new System.Drawing.Point(124, 372);
            this.LoadAllProductsData.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.LoadAllProductsData.Name = "LoadAllProductsData";
            this.LoadAllProductsData.Size = new System.Drawing.Size(172, 21);
            this.LoadAllProductsData.TabIndex = 1;
            this.LoadAllProductsData.Text = "Load";
            this.LoadAllProductsData.UseVisualStyleBackColor = true;
            this.LoadAllProductsData.Click += new System.EventHandler(this.LoadAllProductsData_Click);
            // 
            // textBoxRecentPricesChanges
            // 
            this.textBoxRecentPricesChanges.Location = new System.Drawing.Point(4, 24);
            this.textBoxRecentPricesChanges.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxRecentPricesChanges.Multiline = true;
            this.textBoxRecentPricesChanges.Name = "textBoxRecentPricesChanges";
            this.textBoxRecentPricesChanges.Size = new System.Drawing.Size(116, 161);
            this.textBoxRecentPricesChanges.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recent prices changes";
            // 
            // DataReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRecentPricesChanges);
            this.Controls.Add(this.LoadAllProductsData);
            this.Controls.Add(this.dataGridViewAllProducts);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "DataReview";
            this.Text = "Data Review";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAllProducts;
        private System.Windows.Forms.Button LoadAllProductsData;
        private System.Windows.Forms.TextBox textBoxRecentPricesChanges;
        private System.Windows.Forms.Label label1;
    }
}