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
            this.tabSubjects = new UniProgramGen.SubjectsTab();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabTeachers = new UniProgramGen.TeachersTab();
            this.tabPageRooms = new System.Windows.Forms.TabPage();
            this.tabRooms = new UniProgramGen.RoomsTab();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabGroups = new UniProgramGen.GroupTab();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.tabResults = new UniProgramGen.ResultsTab();
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
            this.tabPageSubjects.Controls.Add(this.tabSubjects);
            this.tabPageSubjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubjects.Name = "tabPageSubjects";
            this.tabPageSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubjects.Size = new System.Drawing.Size(656, 455);
            this.tabPageSubjects.TabIndex = 0;
            this.tabPageSubjects.Text = "Предмети";
            this.tabPageSubjects.UseVisualStyleBackColor = true;
            this.tabPageSubjects.Enter += new System.EventHandler(this.tabPageSubjects_Enter);
            // 
            // tabSubjects
            // 
            this.tabSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSubjects.Location = new System.Drawing.Point(3, 3);
            this.tabSubjects.MinimumSize = new System.Drawing.Size(650, 450);
            this.tabSubjects.Name = "tabSubjects";
            this.tabSubjects.Size = new System.Drawing.Size(650, 450);
            this.tabSubjects.TabIndex = 0;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Controls.Add(this.tabTeachers);
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeachers.Size = new System.Drawing.Size(656, 455);
            this.tabPageTeachers.TabIndex = 1;
            this.tabPageTeachers.Text = "Преподаватели";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            this.tabPageTeachers.Enter += new System.EventHandler(this.tabPageTeachers_Enter);
            // 
            // tabTeachers
            // 
            this.tabTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTeachers.Location = new System.Drawing.Point(3, 3);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Size = new System.Drawing.Size(650, 449);
            this.tabTeachers.TabIndex = 0;
            // 
            // tabPageRooms
            // 
            this.tabPageRooms.Controls.Add(this.tabRooms);
            this.tabPageRooms.Location = new System.Drawing.Point(4, 22);
            this.tabPageRooms.Name = "tabPageRooms";
            this.tabPageRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRooms.Size = new System.Drawing.Size(656, 455);
            this.tabPageRooms.TabIndex = 1;
            this.tabPageRooms.Text = "Стаи";
            this.tabPageRooms.UseVisualStyleBackColor = true;
            this.tabPageRooms.Enter += new System.EventHandler(this.tabPageRooms_Enter);
            // 
            // tabRooms
            // 
            this.tabRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRooms.Location = new System.Drawing.Point(3, 3);
            this.tabRooms.MinimumSize = new System.Drawing.Size(650, 450);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Size = new System.Drawing.Size(650, 450);
            this.tabRooms.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.tabGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(656, 455);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Групи";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            this.tabPageGroups.Enter += new System.EventHandler(this.tabPageGroups_Enter);
            // 
            // tabGroups
            // 
            this.tabGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGroups.Location = new System.Drawing.Point(3, 3);
            this.tabGroups.MinimumSize = new System.Drawing.Size(650, 450);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(650, 450);
            this.tabGroups.TabIndex = 0;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.tabResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(656, 455);
            this.tabPageResults.TabIndex = 2;
            this.tabPageResults.Text = "Програма";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // tabResults
            // 
            this.tabResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabResults.Location = new System.Drawing.Point(3, 3);
            this.tabResults.Name = "tabResults";
            this.tabResults.Size = new System.Drawing.Size(650, 449);
            this.tabResults.TabIndex = 0;
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
        private TeachersTab tabTeachers;
        private SubjectsTab tabSubjects;
        private RoomsTab tabRooms;
        private GroupTab tabGroups;
        private System.Windows.Forms.TabPage tabPageResults;
        private ResultsTab tabResults;
    }
}

