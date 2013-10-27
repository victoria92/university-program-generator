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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.subjectsTab1 = new UniProgramGen.SubjectsTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.teachersTab1 = new UniProgramGen.TeachersTab();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.roomsTab1 = new UniProgramGen.RoomsTab();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupsTab1 = new UniProgramGen.GroupTab();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(650, 450);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.subjectsTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Предмети";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // subjectsTab1
            // 
            this.subjectsTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectsTab1.Location = new System.Drawing.Point(0, 0);
            this.subjectsTab1.MinimumSize = new System.Drawing.Size(650, 450);
            this.subjectsTab1.Name = "subjectsTab1";
            this.subjectsTab1.Size = new System.Drawing.Size(650, 450);
            this.subjectsTab1.Subjects = null;
            this.subjectsTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.teachersTab1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(656, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преподаватели";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // teachersTab1
            // 
            this.teachersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersTab1.Location = new System.Drawing.Point(3, 3);
            this.teachersTab1.Name = "teachersTab1";
            this.teachersTab1.Size = new System.Drawing.Size(650, 449);
            this.teachersTab1.TabIndex = 0;
            this.teachersTab1.Teachers = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.roomsTab1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(656, 455);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Стаи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // roomsTab1
            // 
            this.roomsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsTab1.Location = new System.Drawing.Point(3, 3);
            this.roomsTab1.MinimumSize = new System.Drawing.Size(650, 450);
            this.roomsTab1.Name = "roomsTab1";
            this.roomsTab1.Size = new System.Drawing.Size(650, 450);
            this.roomsTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupsTab1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(656, 455);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Групи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupsTab1
            // 
            this.groupsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsTab1.Groups = null;
            this.groupsTab1.Location = new System.Drawing.Point(3, 3);
            this.groupsTab1.MinimumSize = new System.Drawing.Size(650, 450);
            this.groupsTab1.Name = "groupsTab1";
            this.groupsTab1.Size = new System.Drawing.Size(650, 450);
            this.groupsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 481);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(680, 520);
            this.Name = "MainForm";
            this.Text = "Генериране на програма";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private TeachersTab teachersTab1;
        private SubjectsTab subjectsTab1;
        private RoomsTab roomsTab1;
        private GroupTab groupsTab1;
    }
}

