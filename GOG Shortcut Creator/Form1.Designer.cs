namespace GOG_Shortcut_Creator
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxGalaxyClient = new System.Windows.Forms.TextBox();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.browseGalaxyClient = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(12, 402);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(156, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create Shortcut to Desktop";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 373);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(156, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse for GalaxyClient.exe";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxGalaxyClient
            // 
            this.textBoxGalaxyClient.Location = new System.Drawing.Point(174, 375);
            this.textBoxGalaxyClient.Name = "textBoxGalaxyClient";
            this.textBoxGalaxyClient.Size = new System.Drawing.Size(272, 20);
            this.textBoxGalaxyClient.TabIndex = 4;
            this.textBoxGalaxyClient.Text = "C:\\Program Files (x86)\\GOG Galaxy\\GalaxyClient.exe";
            // 
            // listBoxGames
            // 
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.Location = new System.Drawing.Point(12, 12);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(434, 355);
            this.listBoxGames.TabIndex = 5;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            this.listBoxGames.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // browseGalaxyClient
            // 
            this.browseGalaxyClient.FileName = "GalaxyClient.exe";
            this.browseGalaxyClient.Filter = "GalaxyClient.exe|GalaxyClient.exe";
            this.browseGalaxyClient.InitialDirectory = "C:\\Program Files (x86)\\GOG Galaxy\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "(You can also double the above list to make a shortcut!)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.textBoxGalaxyClient);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GOG 2.0 Shortcut Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonBrowse;
        public System.Windows.Forms.TextBox textBoxGalaxyClient;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.OpenFileDialog browseGalaxyClient;
        private System.Windows.Forms.Label label1;
    }
}

