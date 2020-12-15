namespace inventory_project
{
    partial class adminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.newAssetBtn = new System.Windows.Forms.Button();
            this.showUsersBtn = new System.Windows.Forms.Button();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(728, 534);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(151, 83);
            this.importBtn.TabIndex = 0;
            this.importBtn.Text = "Adatok importálása";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(728, 398);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(151, 91);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Exportálás";
            this.exportBtn.UseVisualStyleBackColor = true;
            // 
            // newAssetBtn
            // 
            this.newAssetBtn.Location = new System.Drawing.Point(728, 257);
            this.newAssetBtn.Name = "newAssetBtn";
            this.newAssetBtn.Size = new System.Drawing.Size(151, 95);
            this.newAssetBtn.TabIndex = 2;
            this.newAssetBtn.Text = "Új eszköz felvétele";
            this.newAssetBtn.UseVisualStyleBackColor = true;
            this.newAssetBtn.Click += new System.EventHandler(this.newAssetBtn_Click);
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Location = new System.Drawing.Point(728, 109);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(151, 99);
            this.showUsersBtn.TabIndex = 3;
            this.showUsersBtn.Text = "Felhasználók megjelenítése";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Location = new System.Drawing.Point(67, 109);
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.Size = new System.Drawing.Size(630, 508);
            this.adminDataGridView.TabIndex = 4;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(67, 30);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(126, 32);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Kijelentkezés";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(551, 40);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "label1";
            // 
            // elapsedTime
            // 
            this.elapsedTime.Enabled = true;
            // 
            // adminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.adminDataGridView);
            this.Controls.Add(this.showUsersBtn);
            this.Controls.Add(this.newAssetBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Name = "adminControl";
            this.Size = new System.Drawing.Size(944, 643);
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button newAssetBtn;
        private System.Windows.Forms.Button showUsersBtn;
        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.Timer elapsedTime;
    }
}
