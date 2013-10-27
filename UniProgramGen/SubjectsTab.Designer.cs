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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.checkedListBoxRoomRequirements = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Изисквания за зала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Преподаватели";
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Items.AddRange(new object[] {
            "Биров",
            "Бабев",
            "Добрев"});
            this.listBoxTeachers.Location = new System.Drawing.Point(188, 106);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTeachers.Size = new System.Drawing.Size(120, 95);
            this.listBoxTeachers.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Продължителност";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(487, 255);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownDuration.TabIndex = 13;
            // 
            // textBoxSubjectName
            // 
            this.textBoxSubjectName.Location = new System.Drawing.Point(205, 33);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(313, 20);
            this.textBoxSubjectName.TabIndex = 12;
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.Items.AddRange(new object[] {
            "УП, Биров, Инф, 1курс лекции",
            "УП, Биров, Инф, 2курс лекции",
            "УП, Биров, Инф, 3курс лекции",
            "УП, Биров, Инф, 4курс лекции",
            "УП, Биров, Инф, 5курс лекции",
            "УП, Биров, Инф, 6курс лекции",
            "УП, Биров, Инф, 7курс лекции"});
            this.listBoxSubjects.Location = new System.Drawing.Point(7, 21);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(163, 394);
            this.listBoxSubjects.TabIndex = 11;
            this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
            // 
            // checkedListBoxRoomRequirements
            // 
            this.checkedListBoxRoomRequirements.FormattingEnabled = true;
            this.checkedListBoxRoomRequirements.Items.AddRange(new object[] {
            "Лекционна зала",
            "Компютърен кабинет",
            "Проектор",
            "Мрежова лаборатория"});
            this.checkedListBoxRoomRequirements.Location = new System.Drawing.Point(398, 106);
            this.checkedListBoxRoomRequirements.Name = "checkedListBoxRoomRequirements";
            this.checkedListBoxRoomRequirements.Size = new System.Drawing.Size(120, 64);
            this.checkedListBoxRoomRequirements.TabIndex = 10;
            this.checkedListBoxRoomRequirements.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxRoomRequirements_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(561, 404);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 26);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добави";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // SubjectsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTeachers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.textBoxSubjectName);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.checkedListBoxRoomRequirements);
            this.Controls.Add(this.buttonAdd);
            this.Name = "SubjectsTab";
            this.Size = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoomRequirements;
        private System.Windows.Forms.Button buttonAdd;

    }
}
