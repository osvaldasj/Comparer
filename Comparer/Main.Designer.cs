namespace Comparer
{
    partial class Main
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
            this.openButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 36);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Select Picture";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(12, 54);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(110, 36);
            this.outButton.TabIndex = 1;
            this.outButton.Text = "Select Output";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(128, 1);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(740, 692);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLabel.Location = new System.Drawing.Point(874, 1);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(476, 692);
            this.mainLabel.TabIndex = 3;
            // 
            // recognizeButton
            // 
            this.recognizeButton.Enabled = false;
            this.recognizeButton.Location = new System.Drawing.Point(12, 96);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(110, 37);
            this.recognizeButton.TabIndex = 4;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.recognizeButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLeftButton.Location = new System.Drawing.Point(12, 660);
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(49, 33);
            this.rotateLeftButton.TabIndex = 5;
            this.rotateLeftButton.Text = "RL";
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Location = new System.Drawing.Point(67, 660);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(49, 33);
            this.rotateRightButton.TabIndex = 6;
            this.rotateRightButton.Text = "RR";
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image Orientation";
            // 
            // imageCheck
            // 
            this.imageCheck.AutoSize = true;
            this.imageCheck.Enabled = false;
            this.imageCheck.Location = new System.Drawing.Point(105, 592);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(15, 14);
            this.imageCheck.TabIndex = 8;
            this.imageCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Image Selected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Selected";
            // 
            // outputCheck
            // 
            this.outputCheck.AutoSize = true;
            this.outputCheck.Enabled = false;
            this.outputCheck.Location = new System.Drawing.Point(105, 617);
            this.outputCheck.Name = "outputCheck";
            this.outputCheck.Size = new System.Drawing.Size(15, 14);
            this.outputCheck.TabIndex = 11;
            this.outputCheck.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 696);
            this.Controls.Add(this.outputCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotateRightButton);
            this.Controls.Add(this.rotateLeftButton);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.openButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.Button rotateLeftButton;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox imageCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox outputCheck;
    }
}