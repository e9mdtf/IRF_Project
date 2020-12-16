namespace inventory_project
{
    partial class newAsset
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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.assetNameTextbox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.assetNameLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(232, 340);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(104, 67);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "&Rendben";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(391, 340);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 67);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "&Mégse";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // assetNameTextbox
            // 
            this.assetNameTextbox.Location = new System.Drawing.Point(329, 31);
            this.assetNameTextbox.Name = "assetNameTextbox";
            this.assetNameTextbox.Size = new System.Drawing.Size(200, 20);
            this.assetNameTextbox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(329, 74);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(329, 124);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoryTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(329, 220);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(329, 273);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(200, 20);
            this.serialTextBox.TabIndex = 7;
            // 
            // assetNameLabel
            // 
            this.assetNameLabel.AutoSize = true;
            this.assetNameLabel.Location = new System.Drawing.Point(229, 34);
            this.assetNameLabel.Name = "assetNameLabel";
            this.assetNameLabel.Size = new System.Drawing.Size(65, 13);
            this.assetNameLabel.TabIndex = 8;
            this.assetNameLabel.Text = "Eszköz név:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(228, 77);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(75, 13);
            this.modelLabel.TabIndex = 9;
            this.modelLabel.Text = "Eszköz model:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(228, 127);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 13);
            this.categoryLabel.TabIndex = 10;
            this.categoryLabel.Text = "Kategória:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(228, 177);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(83, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Beszerzés ideje:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(229, 223);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 13);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Beszerzési ár:";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(229, 276);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(61, 13);
            this.serialLabel.TabIndex = 13;
            this.serialLabel.Text = "Gyári szám:";
            // 
            // newAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.assetNameLabel);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.assetNameTextbox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Name = "newAsset";
            this.Text = "newAsset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label assetNameLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label serialLabel;
        public System.Windows.Forms.TextBox assetNameTextbox;
        public System.Windows.Forms.TextBox modelTextBox;
        public System.Windows.Forms.TextBox categoryTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox serialTextBox;
    }
}