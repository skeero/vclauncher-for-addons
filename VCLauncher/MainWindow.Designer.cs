namespace VCLauncher
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddonsList = new System.Windows.Forms.ListBox();
            this.LaunchTheGame = new System.Windows.Forms.Button();
            this.ExitApp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddonsList);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the addon";
            // 
            // AddonsList
            // 
            this.AddonsList.FormattingEnabled = true;
            this.AddonsList.ItemHeight = 20;
            this.AddonsList.Location = new System.Drawing.Point(17, 25);
            this.AddonsList.Name = "AddonsList";
            this.AddonsList.Size = new System.Drawing.Size(383, 144);
            this.AddonsList.TabIndex = 0;
            this.AddonsList.SelectedIndexChanged += new System.EventHandler(this.OnAddonSelect);
            // 
            // LaunchTheGame
            // 
            this.LaunchTheGame.Enabled = false;
            this.LaunchTheGame.Location = new System.Drawing.Point(341, 200);
            this.LaunchTheGame.Name = "LaunchTheGame";
            this.LaunchTheGame.Size = new System.Drawing.Size(85, 33);
            this.LaunchTheGame.TabIndex = 1;
            this.LaunchTheGame.Text = "Launch";
            this.LaunchTheGame.UseVisualStyleBackColor = true;
            this.LaunchTheGame.Click += new System.EventHandler(this.LaunchTheGame_Click);
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(250, 200);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(85, 33);
            this.ExitApp.TabIndex = 2;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 206);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/skeero";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(438, 244);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.LaunchTheGame);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "VCLauncher v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox AddonsList;
        private System.Windows.Forms.Button LaunchTheGame;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

