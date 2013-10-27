namespace UniProgramGen
{
    partial class SubjectsTab
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
            this.LB_Teachers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NUM_SubjectDuration = new System.Windows.Forms.NumericUpDown();
            this.TB_SubjectName = new System.Windows.Forms.TextBox();
            this.checkedListBoxRoomRequirements = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.GB_SubjectNames = new System.Windows.Forms.GroupBox();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.groupBoxSubjectTeachers = new System.Windows.Forms.GroupBox();
            this.groupBoxRoomRequirements = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_SubjectDuration)).BeginInit();
            this.GB_SubjectNames.SuspendLayout();
            this.groupBoxSubjectTeachers.SuspendLayout();
            this.groupBoxRoomRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Teachers
            // 
            this.LB_Teachers.DisplayMember = "name";
            this.LB_Teachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Teachers.FormattingEnabled = true;
            this.LB_Teachers.Location = new System.Drawing.Point(3, 16);
            this.LB_Teachers.Name = "LB_Teachers";
            this.LB_Teachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_Teachers.Size = new System.Drawing.Size(148, 358);
            this.LB_Teachers.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Продължителност";
            // 
            // NUM_SubjectDuration
            // 
            this.NUM_SubjectDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUM_SubjectDuration.Location = new System.Drawing.Point(532, 198);
            this.NUM_SubjectDuration.Name = "NUM_SubjectDuration";
            this.NUM_SubjectDuration.Size = new System.Drawing.Size(65, 20);
            this.NUM_SubjectDuration.TabIndex = 13;
            // 
            // TB_SubjectName
            // 
            this.TB_SubjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_SubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TB_SubjectName.Location = new System.Drawing.Point(190, 16);
            this.TB_SubjectName.Name = "TB_SubjectName";
            this.TB_SubjectName.Size = new System.Drawing.Size(457, 29);
            this.TB_SubjectName.TabIndex = 12;
            // 
            // checkedListBoxRoomRequirements
            // 
            this.checkedListBoxRoomRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxRoomRequirements.FormattingEnabled = true;
            this.checkedListBoxRoomRequirements.Items.AddRange(new object[] {
            "Лекционна зала",
            "Компютърен кабинет",
            "Проектор",
            "Мрежова лаборатория"});
            this.checkedListBoxRoomRequirements.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxRoomRequirements.Name = "checkedListBoxRoomRequirements";
            this.checkedListBoxRoomRequirements.Size = new System.Drawing.Size(194, 70);
            this.checkedListBoxRoomRequirements.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(566, 418);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 26);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // GB_SubjectNames
            // 
            this.GB_SubjectNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_SubjectNames.Controls.Add(this.listBoxSubjects);
            this.GB_SubjectNames.Location = new System.Drawing.Point(4, 0);
            this.GB_SubjectNames.Name = "GB_SubjectNames";
            this.GB_SubjectNames.Size = new System.Drawing.Size(183, 447);
            this.GB_SubjectNames.TabIndex = 18;
            this.GB_SubjectNames.TabStop = false;
            this.GB_SubjectNames.Text = "Курсове";
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.DisplayMember = "name";
            this.listBoxSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.Location = new System.Drawing.Point(3, 16);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSubjects.Size = new System.Drawing.Size(177, 428);
            this.listBoxSubjects.TabIndex = 12;
            this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
            // 
            // groupBoxSubjectTeachers
            // 
            this.groupBoxSubjectTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSubjectTeachers.Controls.Add(this.LB_Teachers);
            this.groupBoxSubjectTeachers.Location = new System.Drawing.Point(221, 67);
            this.groupBoxSubjectTeachers.Name = "groupBoxSubjectTeachers";
            this.groupBoxSubjectTeachers.Size = new System.Drawing.Size(154, 377);
            this.groupBoxSubjectTeachers.TabIndex = 19;
            this.groupBoxSubjectTeachers.TabStop = false;
            this.groupBoxSubjectTeachers.Text = "Преподаватели";
            // 
            // groupBoxRoomRequirements
            // 
            this.groupBoxRoomRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRoomRequirements.Controls.Add(this.checkedListBoxRoomRequirements);
            this.groupBoxRoomRequirements.Location = new System.Drawing.Point(416, 67);
            this.groupBoxRoomRequirements.Name = "groupBoxRoomRequirements";
            this.groupBoxRoomRequirements.Size = new System.Drawing.Size(200, 89);
            this.groupBoxRoomRequirements.TabIndex = 20;
            this.groupBoxRoomRequirements.TabStop = false;
            this.groupBoxRoomRequirements.Text = "Изисквания за залата";
            // 
            // SubjectsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRoomRequirements);
            this.Controls.Add(this.groupBoxSubjectTeachers);
            this.Controls.Add(this.GB_SubjectNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUM_SubjectDuration);
            this.Controls.Add(this.TB_SubjectName);
            this.Controls.Add(this.buttonAdd);
            this.Name = "SubjectsTab";
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_SubjectDuration)).EndInit();
            this.GB_SubjectNames.ResumeLayout(false);
            this.groupBoxSubjectTeachers.ResumeLayout(false);
            this.groupBoxRoomRequirements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Teachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUM_SubjectDuration;
        private System.Windows.Forms.TextBox TB_SubjectName;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoomRequirements;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox GB_SubjectNames;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.GroupBox groupBoxSubjectTeachers;
        private System.Windows.Forms.GroupBox groupBoxRoomRequirements;

    }
}
