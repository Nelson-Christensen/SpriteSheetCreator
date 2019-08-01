namespace SpriteSheetCreator
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IMG_SpriteDisplay = new System.Windows.Forms.PictureBox();
            this.BTN_ExportSpriteSheet = new System.Windows.Forms.Button();
            this.LST_FilesInProj = new System.Windows.Forms.ListBox();
            this.LST_AnimSets = new System.Windows.Forms.ListBox();
            this.BTN_playAnim = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_AddAnimSet = new System.Windows.Forms.Button();
            this.TXT_SetName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_SpriteDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openFilesToolStripMenuItem.Text = "Open Files";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save Project";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // IMG_SpriteDisplay
            // 
            this.IMG_SpriteDisplay.Location = new System.Drawing.Point(122, 27);
            this.IMG_SpriteDisplay.Name = "IMG_SpriteDisplay";
            this.IMG_SpriteDisplay.Size = new System.Drawing.Size(150, 150);
            this.IMG_SpriteDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_SpriteDisplay.TabIndex = 1;
            this.IMG_SpriteDisplay.TabStop = false;
            // 
            // BTN_ExportSpriteSheet
            // 
            this.BTN_ExportSpriteSheet.Location = new System.Drawing.Point(187, 226);
            this.BTN_ExportSpriteSheet.Name = "BTN_ExportSpriteSheet";
            this.BTN_ExportSpriteSheet.Size = new System.Drawing.Size(75, 23);
            this.BTN_ExportSpriteSheet.TabIndex = 2;
            this.BTN_ExportSpriteSheet.Text = "Export";
            this.BTN_ExportSpriteSheet.UseVisualStyleBackColor = true;
            this.BTN_ExportSpriteSheet.Click += new System.EventHandler(this.BTN_ExportSpriteSheet_Click);
            // 
            // LST_FilesInProj
            // 
            this.LST_FilesInProj.FormattingEnabled = true;
            this.LST_FilesInProj.Location = new System.Drawing.Point(12, 27);
            this.LST_FilesInProj.Name = "LST_FilesInProj";
            this.LST_FilesInProj.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LST_FilesInProj.Size = new System.Drawing.Size(104, 82);
            this.LST_FilesInProj.TabIndex = 3;
            this.LST_FilesInProj.SelectedIndexChanged += new System.EventHandler(this.LST_FilesInProj_SelectedIndexChanged);
            // 
            // LST_AnimSets
            // 
            this.LST_AnimSets.FormattingEnabled = true;
            this.LST_AnimSets.Location = new System.Drawing.Point(12, 115);
            this.LST_AnimSets.Name = "LST_AnimSets";
            this.LST_AnimSets.Size = new System.Drawing.Size(104, 69);
            this.LST_AnimSets.TabIndex = 4;
            this.LST_AnimSets.SelectedIndexChanged += new System.EventHandler(this.LST_AnimSets_SelectedIndexChanged);
            // 
            // BTN_playAnim
            // 
            this.BTN_playAnim.Location = new System.Drawing.Point(152, 183);
            this.BTN_playAnim.Name = "BTN_playAnim";
            this.BTN_playAnim.Size = new System.Drawing.Size(75, 23);
            this.BTN_playAnim.TabIndex = 7;
            this.BTN_playAnim.Text = "Play";
            this.BTN_playAnim.UseVisualStyleBackColor = true;
            this.BTN_playAnim.Click += new System.EventHandler(this.BTN_playAnim_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_AddAnimSet
            // 
            this.BTN_AddAnimSet.Location = new System.Drawing.Point(23, 217);
            this.BTN_AddAnimSet.Name = "BTN_AddAnimSet";
            this.BTN_AddAnimSet.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddAnimSet.TabIndex = 8;
            this.BTN_AddAnimSet.Text = "Add set";
            this.BTN_AddAnimSet.UseVisualStyleBackColor = true;
            this.BTN_AddAnimSet.Click += new System.EventHandler(this.BTN_AddAnimSet_Click);
            // 
            // TXT_SetName
            // 
            this.TXT_SetName.Location = new System.Drawing.Point(12, 191);
            this.TXT_SetName.Name = "TXT_SetName";
            this.TXT_SetName.Size = new System.Drawing.Size(104, 20);
            this.TXT_SetName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TXT_SetName);
            this.Controls.Add(this.BTN_AddAnimSet);
            this.Controls.Add(this.BTN_playAnim);
            this.Controls.Add(this.LST_AnimSets);
            this.Controls.Add(this.LST_FilesInProj);
            this.Controls.Add(this.BTN_ExportSpriteSheet);
            this.Controls.Add(this.IMG_SpriteDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_SpriteDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox IMG_SpriteDisplay;
        private System.Windows.Forms.Button BTN_ExportSpriteSheet;
        private System.Windows.Forms.ListBox LST_FilesInProj;
        private System.Windows.Forms.ListBox LST_AnimSets;
        private System.Windows.Forms.Button BTN_playAnim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_AddAnimSet;
        private System.Windows.Forms.TextBox TXT_SetName;
    }
}

