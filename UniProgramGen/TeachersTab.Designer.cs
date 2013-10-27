namespace UniProgramGen
{
    partial class TeachersTab
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
            this.components = new System.ComponentModel.Container();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.listBoxTeachers = new System.Windows.Forms.ListBox();
            this.listBoxTeacherSaturday = new System.Windows.Forms.ListBox();
            this.listBoxTeacherFriday = new System.Windows.Forms.ListBox();
            this.listBoxTeacherThursday = new System.Windows.Forms.ListBox();
            this.listBoxTeacherWednesday = new System.Windows.Forms.ListBox();
            this.listBoxTeacherTuesday = new System.Windows.Forms.ListBox();
            this.listBoxTeacherMonday = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.groupBoxTeachers = new System.Windows.Forms.GroupBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherName.Location = new System.Drawing.Point(192, 12);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(450, 30);
            this.textBoxTeacherName.TabIndex = 15;
            // 
            // listBoxTeachers
            // 
            this.listBoxTeachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTeachers.FormattingEnabled = true;
            this.listBoxTeachers.Location = new System.Drawing.Point(3, 16);
            this.listBoxTeachers.Name = "listBoxTeachers";
            this.listBoxTeachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeachers.Size = new System.Drawing.Size(177, 428);
            this.listBoxTeachers.TabIndex = 14;
            this.listBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.listBoxTeachers_SelectedIndexChanged);
            // 
            // listBoxTeacherSaturday
            // 
            this.listBoxTeacherSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherSaturday.FormattingEnabled = true;
            this.listBoxTeacherSaturday.ItemHeight = 18;
            this.listBoxTeacherSaturday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherSaturday.Location = new System.Drawing.Point(572, 86);
            this.listBoxTeacherSaturday.Name = "listBoxTeacherSaturday";
            this.listBoxTeacherSaturday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherSaturday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherSaturday.TabIndex = 13;
            this.listBoxTeacherSaturday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // listBoxTeacherFriday
            // 
            this.listBoxTeacherFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherFriday.FormattingEnabled = true;
            this.listBoxTeacherFriday.ItemHeight = 18;
            this.listBoxTeacherFriday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherFriday.Location = new System.Drawing.Point(496, 86);
            this.listBoxTeacherFriday.Name = "listBoxTeacherFriday";
            this.listBoxTeacherFriday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherFriday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherFriday.TabIndex = 12;
            this.listBoxTeacherFriday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // listBoxTeacherThursday
            // 
            this.listBoxTeacherThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherThursday.FormattingEnabled = true;
            this.listBoxTeacherThursday.ItemHeight = 18;
            this.listBoxTeacherThursday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherThursday.Location = new System.Drawing.Point(420, 86);
            this.listBoxTeacherThursday.Name = "listBoxTeacherThursday";
            this.listBoxTeacherThursday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherThursday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherThursday.TabIndex = 11;
            this.listBoxTeacherThursday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // listBoxTeacherWednesday
            // 
            this.listBoxTeacherWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherWednesday.FormattingEnabled = true;
            this.listBoxTeacherWednesday.ItemHeight = 18;
            this.listBoxTeacherWednesday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherWednesday.Location = new System.Drawing.Point(344, 86);
            this.listBoxTeacherWednesday.Name = "listBoxTeacherWednesday";
            this.listBoxTeacherWednesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherWednesday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherWednesday.TabIndex = 10;
            this.listBoxTeacherWednesday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // listBoxTeacherTuesday
            // 
            this.listBoxTeacherTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherTuesday.FormattingEnabled = true;
            this.listBoxTeacherTuesday.ItemHeight = 18;
            this.listBoxTeacherTuesday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherTuesday.Location = new System.Drawing.Point(268, 86);
            this.listBoxTeacherTuesday.Name = "listBoxTeacherTuesday";
            this.listBoxTeacherTuesday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherTuesday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherTuesday.TabIndex = 9;
            this.listBoxTeacherTuesday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // listBoxTeacherMonday
            // 
            this.listBoxTeacherMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTeacherMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTeacherMonday.FormattingEnabled = true;
            this.listBoxTeacherMonday.ItemHeight = 18;
            this.listBoxTeacherMonday.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxTeacherMonday.Location = new System.Drawing.Point(192, 86);
            this.listBoxTeacherMonday.Name = "listBoxTeacherMonday";
            this.listBoxTeacherMonday.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxTeacherMonday.Size = new System.Drawing.Size(70, 310);
            this.listBoxTeacherMonday.TabIndex = 8;
            this.listBoxTeacherMonday.SelectedIndexChanged += new System.EventHandler(this.listBoxTeacher_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Събота";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Петък";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Четвъртък";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Сряда";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Вторник";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Понеделник";
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTeacher.Location = new System.Drawing.Point(566, 411);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(81, 26);
            this.buttonAddTeacher.TabIndex = 41;
            this.buttonAddTeacher.Text = "Добави";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // groupBoxTeachers
            // 
            this.groupBoxTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTeachers.Controls.Add(this.listBoxTeachers);
            this.groupBoxTeachers.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTeachers.Name = "groupBoxTeachers";
            this.groupBoxTeachers.Size = new System.Drawing.Size(183, 447);
            this.groupBoxTeachers.TabIndex = 42;
            this.groupBoxTeachers.TabStop = false;
            this.groupBoxTeachers.Text = "Преподаватели";
            this.groupBoxTeachers.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(UniProgramGen.Data.Teacher);
            // 
            // TeachersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTeachers);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.listBoxTeacherSaturday);
            this.Controls.Add(this.listBoxTeacherFriday);
            this.Controls.Add(this.listBoxTeacherThursday);
            this.Controls.Add(this.listBoxTeacherWednesday);
            this.Controls.Add(this.listBoxTeacherTuesday);
            this.Controls.Add(this.listBoxTeacherMonday);
            this.Name = "TeachersTab";
            this.Size = new System.Drawing.Size(650, 450);
            this.groupBoxTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.ListBox listBoxTeachers;
        private System.Windows.Forms.ListBox listBoxTeacherSaturday;
        private System.Windows.Forms.ListBox listBoxTeacherFriday;
        private System.Windows.Forms.ListBox listBoxTeacherThursday;
        private System.Windows.Forms.ListBox listBoxTeacherWednesday;
        private System.Windows.Forms.ListBox listBoxTeacherTuesday;
        private System.Windows.Forms.ListBox listBoxTeacherMonday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.GroupBox groupBoxTeachers;



    }
}
