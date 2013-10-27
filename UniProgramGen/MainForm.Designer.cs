namespace UniProgramGen
{
    partial class MainForm
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
            this.TABS_UniProgram = new System.Windows.Forms.TabControl();
            this.tabPageSubjects = new System.Windows.Forms.TabPage();
            this.TAB_Subjects = new UniProgramGen.SubjectsTab();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.TABS_Teachers = new UniProgramGen.TeachersTab();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.TAB_Rooms = new UniProgramGen.RoomsTab();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.TAB_Groups = new UniProgramGen.GroupTab();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.resultsTab = new UniProgramGen.ResultsTab();
            this.TABS_UniProgram.SuspendLayout();
            this.tabPageSubjects.SuspendLayout();
            this.tabPageTeachers.SuspendLayout();
            this.tabPageRooms.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABS_UniProgram
            // 
            this.TABS_UniProgram.Controls.Add(this.tabPageSubjects);
            this.TABS_UniProgram.Controls.Add(this.tabPageTeachers);
            this.TABS_UniProgram.Controls.Add(this.tabPageRooms);
            this.TABS_UniProgram.Controls.Add(this.tabPageGroups);
            this.TABS_UniProgram.Controls.Add(this.tabPageResults);
            this.TABS_UniProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABS_UniProgram.Location = new System.Drawing.Point(0, 0);
            this.TABS_UniProgram.MinimumSize = new System.Drawing.Size(650, 450);
            this.TABS_UniProgram.Name = "TABS_UniProgram";
            this.TABS_UniProgram.SelectedIndex = 0;
            this.TABS_UniProgram.Size = new System.Drawing.Size(664, 481);
            this.TABS_UniProgram.TabIndex = 0;
            // 
            // tabPageSubjects
            // 
            this.tabPageSubjects.Controls.Add(this.TAB_Subjects);
            this.tabPageSubjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubjects.Name = "tabPageSubjects";
            this.tabPageSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubjects.Size = new System.Drawing.Size(656, 455);
            this.tabPageSubjects.TabIndex = 0;
            this.tabPageSubjects.Text = "Предмети";
            this.tabPageSubjects.UseVisualStyleBackColor = true;
            // 
            // TAB_Subjects
            // 
            this.TAB_Subjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAB_Subjects.Location = new System.Drawing.Point(3, 3);
            this.TAB_Subjects.MinimumSize = new System.Drawing.Size(650, 450);
            this.TAB_Subjects.Name = "TAB_Subjects";
            this.TAB_Subjects.Size = new System.Drawing.Size(650, 450);
            this.TAB_Subjects.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.TABS_Teachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(656, 455);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // TABS_Teachers
            // 
            this.TABS_Teachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABS_Teachers.Location = new System.Drawing.Point(3, 3);
            this.TABS_Teachers.Name = "TABS_Teachers";
            this.TABS_Teachers.Size = new System.Drawing.Size(650, 449);
            this.TABS_Teachers.TabIndex = 0;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.TAB_Rooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(656, 455);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Стаи";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            // 
            // TAB_Rooms
            // 
            this.TAB_Rooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAB_Rooms.Location = new System.Drawing.Point(3, 3);
            this.TAB_Rooms.MinimumSize = new System.Drawing.Size(650, 450);
            this.TAB_Rooms.Name = "TAB_Rooms";
            this.TAB_Rooms.Size = new System.Drawing.Size(650, 450);
            this.TAB_Rooms.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.TAB_Groups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(656, 455);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Групи";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // TAB_Groups
            // 
            this.TAB_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAB_Groups.Location = new System.Drawing.Point(3, 3);
            this.TAB_Groups.MinimumSize = new System.Drawing.Size(650, 450);
            this.TAB_Groups.Name = "TAB_Groups";
            this.TAB_Groups.Size = new System.Drawing.Size(650, 450);
            this.TAB_Groups.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.resultsTab);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(656, 455);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Програма";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // resultsTab
            // 
            this.resultsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTab.Location = new System.Drawing.Point(3, 3);
            this.resultsTab.Name = "resultsTab";
            this.resultsTab.Size = new System.Drawing.Size(650, 449);
            this.resultsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 481);
            this.Controls.Add(this.TABS_UniProgram);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "MainForm";
            this.Text = "Генериране на програма";
            this.TABS_UniProgram.ResumeLayout(false);
            this.tabPageSubjects.ResumeLayout(false);
            this.tabPageTeachers.ResumeLayout(false);
            this.tabPageRooms.ResumeLayout(false);
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABS_UniProgram;
        private System.Windows.Forms.TabPage tabPageSubjects;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.TabPage tabPageRooms;
        private System.Windows.Forms.TabPage tabPageGroups;
        private TeachersTab TABS_Teachers;
        private SubjectsTab TAB_Subjects;
        private RoomsTab TAB_Rooms;
        private GroupTab TAB_Groups;
        private System.Windows.Forms.TabPage tabPageResults;
        private ResultsTab resultsTab;
    }
}

