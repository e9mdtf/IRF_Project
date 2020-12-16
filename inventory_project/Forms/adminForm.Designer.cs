namespace inventory_project
{
    partial class adminForm
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.showUsersBtn = new System.Windows.Forms.Button();
            this.newAssetBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(230, 43);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "label1";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(42, 33);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 32);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.Text = "Kijelentkezés";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Location = new System.Drawing.Point(42, 94);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(630, 508);
            this.adminDataGridView.TabIndex = 11;
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Location = new System.Drawing.Point(727, 94);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(151, 99);
            this.showUsersBtn.TabIndex = 10;
            this.showUsersBtn.Text = "Felhasználók megjelenítése";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // newAssetBtn
            // 
            this.newAssetBtn.Location = new System.Drawing.Point(727, 236);
            this.newAssetBtn.Name = "newAssetBtn";
            this.newAssetBtn.Size = new System.Drawing.Size(151, 95);
            this.newAssetBtn.TabIndex = 9;
            this.newAssetBtn.Text = "Új eszköz felvétele";
            this.newAssetBtn.UseVisualStyleBackColor = true;
            this.newAssetBtn.Click += new System.EventHandler(this.newAssetBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(727, 384);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(151, 91);
            this.exportBtn.TabIndex = 8;
            this.exportBtn.Text = "Exportálás";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(727, 519);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(151, 83);
            this.importBtn.TabIndex = 7;
            this.importBtn.Text = "Adatok importálása";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 726);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.showUsersBtn);
            this.Controls.Add(this.newAssetBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Name = "adminForm";
            this.Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.Button showUsersBtn;
        private System.Windows.Forms.Button newAssetBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Timer timer1;
    }
}