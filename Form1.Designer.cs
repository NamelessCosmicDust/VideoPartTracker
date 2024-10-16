namespace VideoPartTracker
{
    internal partial class VideoPartTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partBtnUp = new Button();
            partBtnDn = new Button();
            partLabel = new Label();
            partNumber = new Label();
            chapLabel = new Label();
            chapNumber = new Label();
            chapBtnUp = new Button();
            chapBtnDn = new Button();
            shotLabel = new Label();
            shotNumber = new Label();
            shotBtnUp = new Button();
            shotBtnDn = new Button();
            soundBtn = new Button();
            menuStrip = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toggleThemeMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            projectNameTextBox = new TextBox();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // partBtnUp
            // 
            partBtnUp.Font = new Font("Arial", 9.75F);
            partBtnUp.Location = new Point(7, 6);
            partBtnUp.Name = "partBtnUp";
            partBtnUp.Size = new Size(75, 23);
            partBtnUp.TabIndex = 0;
            partBtnUp.Text = "+";
            partBtnUp.UseVisualStyleBackColor = true;
            // 
            // partBtnDn
            // 
            partBtnDn.Font = new Font("Arial", 9.75F);
            partBtnDn.Location = new Point(7, 88);
            partBtnDn.Name = "partBtnDn";
            partBtnDn.Size = new Size(75, 23);
            partBtnDn.TabIndex = 1;
            partBtnDn.Text = "-";
            partBtnDn.UseVisualStyleBackColor = true;
            // 
            // partLabel
            // 
            partLabel.AutoSize = true;
            partLabel.Location = new Point(33, 35);
            partLabel.Name = "partLabel";
            partLabel.Size = new Size(36, 15);
            partLabel.TabIndex = 6;
            partLabel.Text = "PART:";
            // 
            // partNumber
            // 
            partNumber.AutoSize = true;
            partNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            partNumber.Location = new Point(38, 60);
            partNumber.Name = "partNumber";
            partNumber.Size = new Size(35, 25);
            partNumber.TabIndex = 7;
            partNumber.Text = "P#";
            // 
            // chapLabel
            // 
            chapLabel.AutoSize = true;
            chapLabel.Location = new Point(117, 35);
            chapLabel.Name = "chapLabel";
            chapLabel.Size = new Size(61, 15);
            chapLabel.TabIndex = 11;
            chapLabel.Text = "CHAPTER:";
            // 
            // chapNumber
            // 
            chapNumber.AutoSize = true;
            chapNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            chapNumber.Location = new Point(136, 60);
            chapNumber.Name = "chapNumber";
            chapNumber.Size = new Size(35, 25);
            chapNumber.TabIndex = 10;
            chapNumber.Text = "C#";
            // 
            // chapBtnUp
            // 
            chapBtnUp.Font = new Font("Arial", 9.75F);
            chapBtnUp.Location = new Point(110, 6);
            chapBtnUp.Name = "chapBtnUp";
            chapBtnUp.Size = new Size(75, 23);
            chapBtnUp.TabIndex = 9;
            chapBtnUp.Text = "+";
            chapBtnUp.UseVisualStyleBackColor = true;
            // 
            // chapBtnDn
            // 
            chapBtnDn.Font = new Font("Arial", 9.75F);
            chapBtnDn.Location = new Point(106, 89);
            chapBtnDn.Name = "chapBtnDn";
            chapBtnDn.Size = new Size(75, 23);
            chapBtnDn.TabIndex = 8;
            chapBtnDn.Text = "-";
            chapBtnDn.UseVisualStyleBackColor = true;
            // 
            // shotLabel
            // 
            shotLabel.AutoSize = true;
            shotLabel.Location = new Point(220, 35);
            shotLabel.Name = "shotLabel";
            shotLabel.Size = new Size(39, 15);
            shotLabel.TabIndex = 15;
            shotLabel.Text = "SHOT:";
            // 
            // shotNumber
            // 
            shotNumber.AutoSize = true;
            shotNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            shotNumber.Location = new Point(225, 60);
            shotNumber.Name = "shotNumber";
            shotNumber.Size = new Size(34, 25);
            shotNumber.TabIndex = 14;
            shotNumber.Text = "S#";
            // 
            // shotBtnUp
            // 
            shotBtnUp.Font = new Font("Arial", 9.75F);
            shotBtnUp.Location = new Point(202, 6);
            shotBtnUp.Name = "shotBtnUp";
            shotBtnUp.Size = new Size(75, 23);
            shotBtnUp.TabIndex = 13;
            shotBtnUp.Text = "+";
            shotBtnUp.UseVisualStyleBackColor = true;
            // 
            // shotBtnDn
            // 
            shotBtnDn.Font = new Font("Arial", 9.75F);
            shotBtnDn.Location = new Point(202, 89);
            shotBtnDn.Name = "shotBtnDn";
            shotBtnDn.Size = new Size(75, 23);
            shotBtnDn.TabIndex = 12;
            shotBtnDn.Text = "-";
            shotBtnDn.UseVisualStyleBackColor = true;
            // 
            // soundBtn
            // 
            soundBtn.Location = new Point(189, 145);
            soundBtn.Name = "soundBtn";
            soundBtn.Size = new Size(88, 79);
            soundBtn.TabIndex = 17;
            soundBtn.Text = "START\r\nSOUND";
            soundBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.MenuBar;
            menuStrip.Dock = DockStyle.Bottom;
            menuStrip.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, toolStripMenuItem1 });
            menuStrip.Location = new Point(0, 239);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(282, 24);
            menuStrip.TabIndex = 20;
            menuStrip.Text = "menu_Settings";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.BackColor = SystemColors.MenuBar;
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toggleThemeMenuItem });
            settingsToolStripMenuItem.ForeColor = SystemColors.MenuText;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // toggleThemeMenuItem
            // 
            toggleThemeMenuItem.BackColor = SystemColors.MenuBar;
            toggleThemeMenuItem.ForeColor = SystemColors.MenuText;
            toggleThemeMenuItem.Name = "toggleThemeMenuItem";
            toggleThemeMenuItem.Size = new Size(180, 22);
            toggleThemeMenuItem.Text = "Toggle theme";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectNameTextBox.Location = new Point(7, 145);
            projectNameTextBox.Multiline = true;
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(155, 79);
            projectNameTextBox.TabIndex = 21;
            projectNameTextBox.Text = "Text box for\r\nproject name\r\n";
            // 
            // VideoPartTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 263);
            Controls.Add(projectNameTextBox);
            Controls.Add(soundBtn);
            Controls.Add(shotLabel);
            Controls.Add(shotNumber);
            Controls.Add(shotBtnUp);
            Controls.Add(shotBtnDn);
            Controls.Add(chapLabel);
            Controls.Add(chapNumber);
            Controls.Add(chapBtnUp);
            Controls.Add(chapBtnDn);
            Controls.Add(partNumber);
            Controls.Add(partLabel);
            Controls.Add(partBtnDn);
            Controls.Add(partBtnUp);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "VideoPartTracker";
            Text = "Video Part Tracker";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button partBtnUp;
        private Button partBtnDn;
        private Label partLabel;
        private Label partNumber;
        private Button chapBtnUp;
        private Button chapBtnDn;
        private Label chapLabel;
        private Label chapNumber;
        private Button shotBtnUp;
        private Button shotBtnDn;
        private Label shotLabel;
        private Label shotNumber;
        private Button soundBtn;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toggleThemeMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private TextBox projectNameTextBox;
    }
}
