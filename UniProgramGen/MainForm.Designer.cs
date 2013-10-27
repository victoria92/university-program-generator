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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TAB_Subjects = new UniProgramGen.SubjectsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TABS_Teachers = new UniProgramGen.TeachersTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TAB_Rooms = new UniProgramGen.RoomsTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TAB_Groups = new UniProgramGen.GroupTab();
            this.TABS_UniProgram.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TABS_UniProgram
            // 
            this.TABS_UniProgram.Controls.Add(this.tabPage1);
            this.TABS_UniProgram.Controls.Add(this.tabPage2);
            this.TABS_UniProgram.Controls.Add(this.tabPage3);
            this.TABS_UniProgram.Controls.Add(this.tabPage4);
            this.TABS_UniProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABS_UniProgram.Location = new System.Drawing.Point(0, 0);
            this.TABS_UniProgram.MinimumSize = new System.Drawing.Size(650, 450);
            this.TABS_UniProgram.Name = "TABS_UniProgram";
            this.TABS_UniProgram.SelectedIndex = 0;
            this.TABS_UniProgram.Size = new System.Drawing.Size(664, 481);
            this.TABS_UniProgram.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TAB_Subjects);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Предмети";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TAB_Subjects
            // 
            this.TAB_Subjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAB_Subjects.Location = new System.Drawing.Point(0, 0);
            this.TAB_Subjects.MinimumSize = new System.Drawing.Size(650, 450);
            this.TAB_Subjects.Name = "TAB_Subjects";
            this.TAB_Subjects.Size = new System.Drawing.Size(650, 450);
            this.TAB_Subjects.Subjects = null;
            this.TAB_Subjects.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TABS_Teachers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преподаватели";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TABS_Teachers
            // 
            this.TABS_Teachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABS_Teachers.Location = new System.Drawing.Point(3, 3);
            this.TABS_Teachers.Name = "TABS_Teachers";
            this.TABS_Teachers.Size = new System.Drawing.Size(650, 449);
            this.TABS_Teachers.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TAB_Rooms);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 455);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Стаи";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TAB_Groups);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(656, 455);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Групи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TAB_Groups
            // 
            this.TAB_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAB_Groups.Groups = null;
            this.TAB_Groups.Location = new System.Drawing.Point(3, 3);
            this.TAB_Groups.MinimumSize = new System.Drawing.Size(650, 450);
            this.TAB_Groups.Name = "TAB_Groups";
            this.TAB_Groups.Size = new System.Drawing.Size(650, 450);
            this.TAB_Groups.TabIndex = 0;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABS_UniProgram;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private TeachersTab TABS_Teachers;
        private SubjectsTab TAB_Subjects;
        private RoomsTab TAB_Rooms;
        private GroupTab TAB_Groups;
    }
}

