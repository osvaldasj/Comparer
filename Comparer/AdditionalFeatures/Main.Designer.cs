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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.recognizeButton = new System.Windows.Forms.Button();
            this.rotateLeftButton = new System.Windows.Forms.Button();
            this.rotateRightButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.moneySaved = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.nonWebBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spentLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spendingsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.currSpentLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReviewData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(32, 29);
            this.openButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(293, 86);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Select Picture";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(341, 2);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(1973, 1650);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainLabel.Location = new System.Drawing.Point(2331, 2);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(1269, 637);
            this.mainLabel.TabIndex = 3;
            // 
            // recognizeButton
            // 
            this.recognizeButton.Enabled = false;
            this.recognizeButton.Location = new System.Drawing.Point(32, 129);
            this.recognizeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.recognizeButton.Name = "recognizeButton";
            this.recognizeButton.Size = new System.Drawing.Size(293, 88);
            this.recognizeButton.TabIndex = 4;
            this.recognizeButton.Text = "Recognize";
            this.recognizeButton.UseVisualStyleBackColor = true;
            this.recognizeButton.Click += new System.EventHandler(this.recognizeButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotateLeftButton.Location = new System.Drawing.Point(32, 1574);
            this.rotateLeftButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(131, 79);
            this.rotateLeftButton.TabIndex = 5;
            this.rotateLeftButton.Text = "RL";
            this.rotateLeftButton.UseVisualStyleBackColor = true;
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Location = new System.Drawing.Point(179, 1574);
            this.rotateRightButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(131, 79);
            this.rotateRightButton.TabIndex = 6;
            this.rotateRightButton.Text = "RR";
            this.rotateRightButton.UseVisualStyleBackColor = true;
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 1536);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image Orientation";
            // 
            // imageCheck
            // 
            this.imageCheck.AutoSize = true;
            this.imageCheck.Enabled = false;
            this.imageCheck.Location = new System.Drawing.Point(280, 1354);
            this.imageCheck.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imageCheck.Name = "imageCheck";
            this.imageCheck.Size = new System.Drawing.Size(34, 33);
            this.imageCheck.TabIndex = 8;
            this.imageCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 1354);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Image Selected";
            // 
            // compareButton
            // 
            this.compareButton.Enabled = false;
            this.compareButton.Location = new System.Drawing.Point(32, 231);
            this.compareButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(293, 86);
            this.compareButton.TabIndex = 12;
            this.compareButton.Text = "Compare with Database";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // moneySaved
            // 
            this.moneySaved.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moneySaved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moneySaved.Location = new System.Drawing.Point(2331, 742);
            this.moneySaved.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.moneySaved.Name = "moneySaved";
            this.moneySaved.Size = new System.Drawing.Size(1269, 911);
            this.moneySaved.TabIndex = 16;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(8, 594);
            this.btnTest.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(312, 79);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test Button";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // nonWebBtn
            // 
            this.nonWebBtn.Location = new System.Drawing.Point(8, 687);
            this.nonWebBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nonWebBtn.Name = "nonWebBtn";
            this.nonWebBtn.Size = new System.Drawing.Size(317, 83);
            this.nonWebBtn.TabIndex = 18;
            this.nonWebBtn.Text = "no web";
            this.nonWebBtn.UseVisualStyleBackColor = true;
            this.nonWebBtn.Click += new System.EventHandler(this.nonWebBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(1432, 29);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(256, 58);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 994);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total money spent:";
            // 
            // spentLabel
            // 
            this.spentLabel.AutoSize = true;
            this.spentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spentLabel.Location = new System.Drawing.Point(19, 1059);
            this.spentLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.spentLabel.Name = "spentLabel";
            this.spentLabel.Size = new System.Drawing.Size(54, 58);
            this.spentLabel.TabIndex = 21;
            this.spentLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 1059);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 58);
            this.label4.TabIndex = 22;
            this.label4.Text = "Eur";
            // 
            // spendingsButton
            // 
            this.spendingsButton.Location = new System.Drawing.Point(19, 1159);
            this.spendingsButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.spendingsButton.Name = "spendingsButton";
            this.spendingsButton.Size = new System.Drawing.Size(317, 83);
            this.spendingsButton.TabIndex = 23;
            this.spendingsButton.Text = "Update Spendings";
            this.spendingsButton.UseVisualStyleBackColor = true;
            this.spendingsButton.Click += new System.EventHandler(this.spendingsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 894);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 58);
            this.label5.TabIndex = 26;
            this.label5.Text = "Eur";
            // 
            // currSpentLabel
            // 
            this.currSpentLabel.AutoSize = true;
            this.currSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currSpentLabel.Location = new System.Drawing.Point(19, 894);
            this.currSpentLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.currSpentLabel.Name = "currSpentLabel";
            this.currSpentLabel.Size = new System.Drawing.Size(54, 58);
            this.currSpentLabel.TabIndex = 25;
            this.currSpentLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 830);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Current money spent:";
            // 
            // btnReviewData
            // 
            this.btnReviewData.Location = new System.Drawing.Point(32, 328);
            this.btnReviewData.Name = "btnReviewData";
            this.btnReviewData.Size = new System.Drawing.Size(293, 90);
            this.btnReviewData.TabIndex = 27;
            this.btnReviewData.Text = "Review Data";
            this.btnReviewData.UseVisualStyleBackColor = true;
            this.btnReviewData.Click += new System.EventHandler(this.btnReviewData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3632, 1660);
            this.Controls.Add(this.btnReviewData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currSpentLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spendingsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spentLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.nonWebBtn);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.moneySaved);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotateRightButton);
            this.Controls.Add(this.rotateLeftButton);
            this.Controls.Add(this.recognizeButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.openButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button recognizeButton;
        private System.Windows.Forms.Button rotateLeftButton;
        private System.Windows.Forms.Button rotateRightButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox imageCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label moneySaved;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button nonWebBtn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label spentLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button spendingsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currSpentLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReviewData;
    }
}