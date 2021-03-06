﻿namespace Comparer
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
            this.components = new System.ComponentModel.Container();
            this.productListResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productListResponseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewAllProducts = new System.Windows.Forms.DataGridView();
            this.LoadAllProductsData = new System.Windows.Forms.Button();
            this.textBoxRecentPricesChanges = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productListResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListResponseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // productListResponseBindingSource
            // 
            this.productListResponseBindingSource.DataSource = typeof(Comparer.CompWebService.ProductListResponse);
            // 
            // productListResponseBindingSource1
            // 
            this.productListResponseBindingSource1.DataSource = typeof(Comparer.CompWebService.ProductListResponse);
            // 
            // dataGridViewAllProducts
            // 
            this.dataGridViewAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProducts.Location = new System.Drawing.Point(946, 12);
            this.dataGridViewAllProducts.Name = "dataGridViewAllProducts";
            this.dataGridViewAllProducts.RowTemplate.Height = 40;
            this.dataGridViewAllProducts.Size = new System.Drawing.Size(459, 869);
            this.dataGridViewAllProducts.TabIndex = 0;
            // 
            // LoadAllProductsData
            // 
            this.LoadAllProductsData.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.LoadAllProductsData.Location = new System.Drawing.Point(946, 888);
            this.LoadAllProductsData.Name = "LoadAllProductsData";
            this.LoadAllProductsData.Size = new System.Drawing.Size(459, 50);
            this.LoadAllProductsData.TabIndex = 1;
            this.LoadAllProductsData.Text = "Load";
            this.LoadAllProductsData.UseVisualStyleBackColor = true;
            this.LoadAllProductsData.Click += new System.EventHandler(this.LoadAllProductsData_Click);
            // 
            // textBoxRecentPricesChanges
            // 
            this.textBoxRecentPricesChanges.Location = new System.Drawing.Point(12, 57);
            this.textBoxRecentPricesChanges.Multiline = true;
            this.textBoxRecentPricesChanges.Name = "textBoxRecentPricesChanges";
            this.textBoxRecentPricesChanges.Size = new System.Drawing.Size(304, 379);
            this.textBoxRecentPricesChanges.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recent prices changes";
            // 
            // DataReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 950);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRecentPricesChanges);
            this.Controls.Add(this.LoadAllProductsData);
            this.Controls.Add(this.dataGridViewAllProducts);
            this.Name = "DataReview";
            this.Text = "Data Review";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productListResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productListResponseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productListResponseBindingSource;
        private System.Windows.Forms.BindingSource productListResponseBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewAllProducts;
        private System.Windows.Forms.Button LoadAllProductsData;
        private System.Windows.Forms.TextBox textBoxRecentPricesChanges;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}