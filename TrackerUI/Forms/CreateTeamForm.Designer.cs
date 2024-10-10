
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contestantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tournamentViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contestantViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTeamCaptainButton = new System.Windows.Forms.Button();
            this.selectTeamCaptainDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamCaptainLabel = new System.Windows.Forms.Label();
            this.addTeamUserButton = new System.Windows.Forms.Button();
            this.selectTeamUserDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamUserLabel = new System.Windows.Forms.Label();
            this.createNewContestantGroupBox = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.contestantNameValue = new System.Windows.Forms.TextBox();
            this.contestantNameLabel = new System.Windows.Forms.Label();
            this.createNewContestantButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.createNewContestantGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.AccessibleName = "teamNameValue";
            this.teamNameValue.Location = new System.Drawing.Point(39, 138);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(290, 35);
            this.teamNameValue.TabIndex = 19;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AccessibleName = "teamNameLabel";
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamNameLabel.Location = new System.Drawing.Point(32, 98);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 18;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AccessibleName = "headerLabel";
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 17;
            this.headerLabel.Text = "Create Team";
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleName = "menuStrip";
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tournamentToolStripMenuItem,
            this.teamToolStripMenuItem,
            this.contestantToolStripMenuItem,
            this.prizeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.addToolStripMenuItem.Text = "Add...";
            // 
            // tournamentToolStripMenuItem
            // 
            this.tournamentToolStripMenuItem.Name = "tournamentToolStripMenuItem";
            this.tournamentToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tournamentToolStripMenuItem.Text = "Tournament";
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // contestantToolStripMenuItem
            // 
            this.contestantToolStripMenuItem.Name = "contestantToolStripMenuItem";
            this.contestantToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.contestantToolStripMenuItem.Text = "Contestant";
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.prizeToolStripMenuItem.Text = "Prize";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tournamentViewerToolStripMenuItem,
            this.teamViewerToolStripMenuItem,
            this.contestantViewerToolStripMenuItem,
            this.userViewerToolStripMenuItem,
            this.prizeViewerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tournamentViewerToolStripMenuItem
            // 
            this.tournamentViewerToolStripMenuItem.Name = "tournamentViewerToolStripMenuItem";
            this.tournamentViewerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tournamentViewerToolStripMenuItem.Text = "Tournament Viewer";
            // 
            // teamViewerToolStripMenuItem
            // 
            this.teamViewerToolStripMenuItem.Name = "teamViewerToolStripMenuItem";
            this.teamViewerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.teamViewerToolStripMenuItem.Text = "Team Viewer";
            // 
            // contestantViewerToolStripMenuItem
            // 
            this.contestantViewerToolStripMenuItem.Name = "contestantViewerToolStripMenuItem";
            this.contestantViewerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contestantViewerToolStripMenuItem.Text = "Contestant Viewer";
            // 
            // userViewerToolStripMenuItem
            // 
            this.userViewerToolStripMenuItem.Name = "userViewerToolStripMenuItem";
            this.userViewerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.userViewerToolStripMenuItem.Text = "User Viewer";
            // 
            // prizeViewerToolStripMenuItem
            // 
            this.prizeViewerToolStripMenuItem.Name = "prizeViewerToolStripMenuItem";
            this.prizeViewerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.prizeViewerToolStripMenuItem.Text = "Prize Viewer";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1,
            this.userToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.loginToolStripMenuItem.Text = "Account";
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem.Text = "User Info";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // selectTeamCaptainButton
            // 
            this.selectTeamCaptainButton.AccessibleName = "selectTeamCaptainButton";
            this.selectTeamCaptainButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.selectTeamCaptainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.selectTeamCaptainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.selectTeamCaptainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTeamCaptainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamCaptainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamCaptainButton.Location = new System.Drawing.Point(346, 210);
            this.selectTeamCaptainButton.Name = "selectTeamCaptainButton";
            this.selectTeamCaptainButton.Size = new System.Drawing.Size(125, 35);
            this.selectTeamCaptainButton.TabIndex = 23;
            this.selectTeamCaptainButton.Text = "Select";
            this.selectTeamCaptainButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamCaptainDropDown
            // 
            this.selectTeamCaptainDropDown.AccessibleName = "selectTeamCaptainDropDown";
            this.selectTeamCaptainDropDown.FormattingEnabled = true;
            this.selectTeamCaptainDropDown.Location = new System.Drawing.Point(39, 209);
            this.selectTeamCaptainDropDown.Name = "selectTeamCaptainDropDown";
            this.selectTeamCaptainDropDown.Size = new System.Drawing.Size(290, 38);
            this.selectTeamCaptainDropDown.TabIndex = 22;
            // 
            // selectTeamCaptainLabel
            // 
            this.selectTeamCaptainLabel.AccessibleName = "selectTeamCaptainLabel";
            this.selectTeamCaptainLabel.AutoSize = true;
            this.selectTeamCaptainLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamCaptainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamCaptainLabel.Location = new System.Drawing.Point(34, 176);
            this.selectTeamCaptainLabel.Name = "selectTeamCaptainLabel";
            this.selectTeamCaptainLabel.Size = new System.Drawing.Size(200, 30);
            this.selectTeamCaptainLabel.TabIndex = 21;
            this.selectTeamCaptainLabel.Text = "Select Team Captain";
            // 
            // addTeamUserButton
            // 
            this.addTeamUserButton.AccessibleName = "addTeamUserButton";
            this.addTeamUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamUserButton.Location = new System.Drawing.Point(346, 284);
            this.addTeamUserButton.Name = "addTeamUserButton";
            this.addTeamUserButton.Size = new System.Drawing.Size(125, 35);
            this.addTeamUserButton.TabIndex = 26;
            this.addTeamUserButton.Text = "Add";
            this.addTeamUserButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamUserDropDown
            // 
            this.selectTeamUserDropDown.AccessibleName = "selectTeamUserDropDown";
            this.selectTeamUserDropDown.FormattingEnabled = true;
            this.selectTeamUserDropDown.Location = new System.Drawing.Point(39, 283);
            this.selectTeamUserDropDown.Name = "selectTeamUserDropDown";
            this.selectTeamUserDropDown.Size = new System.Drawing.Size(290, 38);
            this.selectTeamUserDropDown.TabIndex = 25;
            // 
            // selectTeamUserLabel
            // 
            this.selectTeamUserLabel.AccessibleName = "selectTeamUserLabel";
            this.selectTeamUserLabel.AutoSize = true;
            this.selectTeamUserLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamUserLabel.Location = new System.Drawing.Point(34, 250);
            this.selectTeamUserLabel.Name = "selectTeamUserLabel";
            this.selectTeamUserLabel.Size = new System.Drawing.Size(115, 30);
            this.selectTeamUserLabel.TabIndex = 24;
            this.selectTeamUserLabel.Text = "Select User";
            // 
            // createNewContestantGroupBox
            // 
            this.createNewContestantGroupBox.AccessibleName = "createNewContestantGroupBox";
            this.createNewContestantGroupBox.Controls.Add(this.createNewContestantButton);
            this.createNewContestantGroupBox.Controls.Add(this.contestantNameValue);
            this.createNewContestantGroupBox.Controls.Add(this.contestantNameLabel);
            this.createNewContestantGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewContestantGroupBox.Location = new System.Drawing.Point(39, 338);
            this.createNewContestantGroupBox.Name = "createNewContestantGroupBox";
            this.createNewContestantGroupBox.Size = new System.Drawing.Size(346, 61);
            this.createNewContestantGroupBox.TabIndex = 27;
            this.createNewContestantGroupBox.TabStop = false;
            this.createNewContestantGroupBox.Text = "Create New Contestant";
            // 
            // progressBar
            // 
            this.progressBar.AccessibleName = "progressBar";
            this.progressBar.Location = new System.Drawing.Point(379, 444);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(401, 23);
            this.progressBar.TabIndex = 15;
            // 
            // contestantNameValue
            // 
            this.contestantNameValue.AccessibleName = "contestantNameValue";
            this.contestantNameValue.Location = new System.Drawing.Point(64, 22);
            this.contestantNameValue.Name = "contestantNameValue";
            this.contestantNameValue.Size = new System.Drawing.Size(131, 29);
            this.contestantNameValue.TabIndex = 11;
            // 
            // contestantNameLabel
            // 
            this.contestantNameLabel.AccessibleName = "contestantNameLabel";
            this.contestantNameLabel.AutoSize = true;
            this.contestantNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contestantNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.contestantNameLabel.Location = new System.Drawing.Point(6, 25);
            this.contestantNameLabel.Name = "contestantNameLabel";
            this.contestantNameLabel.Size = new System.Drawing.Size(52, 21);
            this.contestantNameLabel.TabIndex = 10;
            this.contestantNameLabel.Text = "Name";
            // 
            // createNewContestantButton
            // 
            this.createNewContestantButton.AccessibleName = "createNewContestantButton";
            this.createNewContestantButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createNewContestantButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createNewContestantButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createNewContestantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewContestantButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewContestantButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createNewContestantButton.Location = new System.Drawing.Point(211, 20);
            this.createNewContestantButton.Name = "createNewContestantButton";
            this.createNewContestantButton.Size = new System.Drawing.Size(125, 35);
            this.createNewContestantButton.TabIndex = 28;
            this.createNewContestantButton.Text = "Create";
            this.createNewContestantButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.AccessibleName = "teamMembersListBox";
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 21;
            this.teamMembersListBox.Location = new System.Drawing.Point(502, 98);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(259, 298);
            this.teamMembersListBox.TabIndex = 28;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.AccessibleName = "deleteMemberButton";
            this.deleteMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteMemberButton.Location = new System.Drawing.Point(502, 403);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(125, 35);
            this.deleteMemberButton.TabIndex = 29;
            this.deleteMemberButton.Text = "Delete";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.AccessibleName = "createTeamButton";
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTeamButton.Location = new System.Drawing.Point(129, 403);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(125, 70);
            this.createTeamButton.TabIndex = 30;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 479);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.createNewContestantGroupBox);
            this.Controls.Add(this.addTeamUserButton);
            this.Controls.Add(this.selectTeamUserDropDown);
            this.Controls.Add(this.selectTeamUserLabel);
            this.Controls.Add(this.selectTeamCaptainButton);
            this.Controls.Add(this.selectTeamCaptainDropDown);
            this.Controls.Add(this.selectTeamCaptainLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.createNewContestantGroupBox.ResumeLayout(false);
            this.createNewContestantGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contestantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tournamentViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contestantViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prizeViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button selectTeamCaptainButton;
        private System.Windows.Forms.ComboBox selectTeamCaptainDropDown;
        private System.Windows.Forms.Label selectTeamCaptainLabel;
        private System.Windows.Forms.Button addTeamUserButton;
        private System.Windows.Forms.ComboBox selectTeamUserDropDown;
        private System.Windows.Forms.Label selectTeamUserLabel;
        private System.Windows.Forms.GroupBox createNewContestantGroupBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox contestantNameValue;
        private System.Windows.Forms.Label contestantNameLabel;
        private System.Windows.Forms.Button createNewContestantButton;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}